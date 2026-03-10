import 'package:window_manager/window_manager.dart';
import 'package:flutter/material.dart';
import 'package:sample_app/widgets/TitleBarButton.dart';

// ---------------------------------------------------------------------------
// CUSTOM TITLE BAR
// ---------------------------------------------------------------------------

// Extracted as its own StatelessWidget so it can be reused on every page
// Think of it as a UserControl you drop onto each Form
class CustomTitleBar extends StatelessWidget {
  final String title;
  final IconData icon;
  final VoidCallback? onMinimize;
  final VoidCallback? onMaximize;
  final VoidCallback? onClose;

  const CustomTitleBar({
    super.key,
    required this.title,
    this.icon = Icons.bar_chart,
    this.onMinimize,
    this.onMaximize,
    this.onClose,
  });

  @override
  Widget build(BuildContext context) {
    // DragToMoveArea makes the entire bar drag the window —
    // equivalent to overriding WndProc for WM_NCHITTEST in WinForms
    return DragToMoveArea(
      child: Container(
        height: 52,
        color: Colors.indigo.shade900,
        padding: const EdgeInsets.symmetric(horizontal: 16),
        child: Row(
          children: [
            Icon(icon, color: Colors.white, size: 20),
            const SizedBox(width: 10),
            Text(
              title,
              style: const TextStyle(
                color: Colors.white,
                fontSize: 14,
                fontWeight: FontWeight.w600,
                letterSpacing: 0.5,
              ),
            ),
            const Spacer(),
            TitleBarButton(
              icon: Icons.remove,
              tooltip: 'Minimize',
              onPressed: onMinimize ?? () => windowManager.minimize(),
            ),
            TitleBarButton(
              icon: Icons.crop_square,
              tooltip: 'Maximize',
              onPressed: onMaximize ?? () async {
                if (await windowManager.isMaximized()) {
                  windowManager.restore();
                } else {
                  windowManager.maximize();
                }
              },
            ),
            TitleBarButton(
              icon: Icons.close,
              tooltip: 'Close',
              color: Colors.red.shade400,
              onPressed: () {
                  windowManager.destroy();  
              },
            ),
          ],
        ),
      ),
    );
  }
}