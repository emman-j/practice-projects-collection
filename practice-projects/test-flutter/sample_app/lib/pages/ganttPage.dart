import 'package:flutter/material.dart';
import '../widgets/customTitleBar.dart';
import 'dart:math';
// ---------------------------------------------------------------------------
// DATA MODEL
// ---------------------------------------------------------------------------

class GanttTask {
  final String name;
  final int startDay;
  final int duration;
  final Color color;

  const GanttTask({
    required this.name,
    required this.startDay,
    required this.duration,
    required this.color,
  });

  GanttTask copyWith({String? name, int? startDay, int? duration, Color? color}) {
    return GanttTask(
      name: name ?? this.name,
      startDay: startDay ?? this.startDay,
      duration: duration ?? this.duration,
      color: color ?? this.color,
    );
  }
}

// ---------------------------------------------------------------------------
// GANTT PAGE
// ---------------------------------------------------------------------------

class GanttPage extends StatefulWidget {
  const GanttPage({super.key});

  @override
  State<GanttPage> createState() => _GanttPageState();
}

class _GanttPageState extends State<GanttPage> {
  static const int _totalDays = 20;
  final _random = Random();

  final List<Color> _taskColors = [
    Colors.indigo,
    Colors.teal,
    Colors.orange,
    Colors.pink,
    Colors.purple,
    Colors.green,
  ];

  late List<GanttTask> _tasks;

  @override
  void initState() {
    super.initState();
    _tasks = _buildInitialTasks();
  }

  List<GanttTask> _buildInitialTasks() {
    return [
      GanttTask(name: 'Planning',    startDay: 0,  duration: 4, color: Colors.indigo),
      GanttTask(name: 'Design',      startDay: 3,  duration: 5, color: Colors.teal),
      GanttTask(name: 'Development', startDay: 6,  duration: 8, color: Colors.orange),
      GanttTask(name: 'Testing',     startDay: 12, duration: 4, color: Colors.pink),
      GanttTask(name: 'Deployment',  startDay: 15, duration: 3, color: Colors.purple),
      GanttTask(name: 'Review',      startDay: 17, duration: 3, color: Colors.green),
    ];
  }

  void _randomizeTasks() {
    setState(() {
      _tasks = _tasks.map((task) {
        final start    = _random.nextInt(_totalDays - 3);
        final duration = _random.nextInt(6) + 2;
        final color    = _taskColors[_random.nextInt(_taskColors.length)];
        return task.copyWith(
          startDay: start,
          duration: min(duration, _totalDays - start),
          color: color,
        );
      }).toList();
    });
  }

  void _resetTasks() {
    setState(() => _tasks = _buildInitialTasks());
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: const Color(0xFFF5F6FA),

      // No appBar — custom title bar replaces it
      body: Column(
        children: [

          // Custom title bar — close button logs out (pops back to login)
          CustomTitleBar(
            title: 'Gantt App  —  Project Timeline',
            icon: Icons.bar_chart,
            // onClose defaults to Navigator.pop() which returns to LoginPage
          ),

          // Chart + buttons fill remaining space
          Expanded(
            child: Padding(
              padding: const EdgeInsets.all(24),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [

                  const Text(
                    'Project Timeline',
                    style: TextStyle(fontSize: 20, fontWeight: FontWeight.bold),
                  ),
                  const SizedBox(height: 4),
                  Text(
                    '$_totalDays-day schedule  •  ${_tasks.length} tasks',
                    style: const TextStyle(color: Colors.grey),
                  ),
                  const SizedBox(height: 24),

                  Expanded(
                    child: Card(
                      elevation: 2,
                      shape: RoundedRectangleBorder(
                        borderRadius: BorderRadius.circular(12),
                      ),
                      child: Padding(
                        padding: const EdgeInsets.all(16),
                        child: Column(
                          children: [
                            _DayHeader(totalDays: _totalDays),
                            const Divider(height: 16),
                            Expanded(
                              child: ListView.separated(
                                itemCount: _tasks.length,
                                separatorBuilder: (_, __) =>
                                    const SizedBox(height: 8),
                                itemBuilder: (context, index) {
                                  return _GanttRow(
                                    task: _tasks[index],
                                    totalDays: _totalDays,
                                  );
                                },
                              ),
                            ),
                          ],
                        ),
                      ),
                    ),
                  ),

                  const SizedBox(height: 24),

                  Row(
                    mainAxisAlignment: MainAxisAlignment.center,
                    children: [
                      ElevatedButton.icon(
                        onPressed: _randomizeTasks,
                        icon: const Icon(Icons.shuffle),
                        label: const Text('Randomize Tasks'),
                        style: ElevatedButton.styleFrom(
                          backgroundColor: Colors.indigo,
                          foregroundColor: Colors.white,
                          padding: const EdgeInsets.symmetric(
                              horizontal: 24, vertical: 14),
                          shape: RoundedRectangleBorder(
                            borderRadius: BorderRadius.circular(8),
                          ),
                        ),
                      ),
                      const SizedBox(width: 12),
                      OutlinedButton.icon(
                        onPressed: _resetTasks,
                        icon: const Icon(Icons.refresh),
                        label: const Text('Reset'),
                        style: OutlinedButton.styleFrom(
                          padding: const EdgeInsets.symmetric(
                              horizontal: 24, vertical: 14),
                          shape: RoundedRectangleBorder(
                            borderRadius: BorderRadius.circular(8),
                          ),
                        ),
                      ),
                    ],
                  ),
                ],
              ),
            ),
          ),
        ],
      ),
    );
  }
}

// ---------------------------------------------------------------------------
// DAY HEADER WIDGET
// ---------------------------------------------------------------------------

class _DayHeader extends StatelessWidget {
  final int totalDays;
  const _DayHeader({required this.totalDays});

  @override
  Widget build(BuildContext context) {
    return Row(
      children: [
        const SizedBox(width: 110),
        Expanded(
          child: Row(
            children: List.generate(totalDays, (i) {
              return Expanded(
                child: Center(
                  child: Text(
                    '${i + 1}',
                    style: const TextStyle(
                      fontSize: 10,
                      color: Colors.grey,
                      fontWeight: FontWeight.w600,
                    ),
                  ),
                ),
              );
            }),
          ),
        ),
      ],
    );
  }
}

// ---------------------------------------------------------------------------
// GANTT ROW WIDGET
// ---------------------------------------------------------------------------

class _GanttRow extends StatelessWidget {
  final GanttTask task;
  final int totalDays;

  const _GanttRow({required this.task, required this.totalDays});

  @override
  Widget build(BuildContext context) {
    return SizedBox(
      height: 36,
      child: Row(
        children: [
          SizedBox(
            width: 110,
            child: Text(
              task.name,
              style: const TextStyle(
                fontSize: 13,
                fontWeight: FontWeight.w500,
              ),
              overflow: TextOverflow.ellipsis,
            ),
          ),
          Expanded(
            child: LayoutBuilder(
              builder: (context, constraints) {
                final totalWidth = constraints.maxWidth;
                final dayWidth   = totalWidth / totalDays;
                final barLeft    = task.startDay * dayWidth;
                final barWidth   = task.duration * dayWidth;

                return Stack(
                  children: [
                    Row(
                      children: List.generate(totalDays, (i) {
                        return Container(
                          width: dayWidth,
                          decoration: BoxDecoration(
                            border: Border(
                              right: BorderSide(
                                color: Colors.grey.shade200,
                                width: 1,
                              ),
                            ),
                          ),
                        );
                      }),
                    ),
                    AnimatedPositioned(
                      duration: const Duration(milliseconds: 400),
                      curve: Curves.easeInOut,
                      left: barLeft,
                      top: 4,
                      bottom: 4,
                      child: AnimatedContainer(
                        duration: const Duration(milliseconds: 400),
                        curve: Curves.easeInOut,
                        width: barWidth,
                        decoration: BoxDecoration(
                          color: task.color.withOpacity(0.85),
                          borderRadius: BorderRadius.circular(6),
                          boxShadow: [
                            BoxShadow(
                              color: task.color.withOpacity(0.3),
                              blurRadius: 4,
                              offset: const Offset(0, 2),
                            ),
                          ],
                        ),
                        child: Center(
                          child: Text(
                            '${task.duration}d',
                            style: const TextStyle(
                              color: Colors.white,
                              fontSize: 11,
                              fontWeight: FontWeight.bold,
                            ),
                          ),
                        ),
                      ),
                    ),
                  ],
                );
              },
            ),
          ),
        ],
      ),
    );
  }
}