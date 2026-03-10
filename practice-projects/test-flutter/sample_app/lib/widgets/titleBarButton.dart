import 'package:flutter/material.dart';

// ---------------------------------------------------------------------------
// CUSTOM TITLE BAR BUTTON
// ---------------------------------------------------------------------------

// Reusable title bar button with hover effect
// StatefulWidget needed because hover state (_hovering) changes
class TitleBarButton extends StatefulWidget {
  final IconData icon;
  final String tooltip;
  final Color? color;
  final VoidCallback onPressed;

  const TitleBarButton({
    required this.icon,
    required this.tooltip,
    required this.onPressed,
    this.color,
  });

  @override
  State<TitleBarButton> createState() => _TitleBarButtonState();
}

class _TitleBarButtonState extends State<TitleBarButton> {
  // Tracks whether the mouse is hovering over this button
  bool _hovering = false;

  @override
  Widget build(BuildContext context) {
    // MouseRegion fires onEnter/onExit when the cursor moves in/out
    // equivalent to WinForms MouseEnter / MouseLeave events
    return MouseRegion(
      onEnter: (_) => setState(() => _hovering = true),
      onExit:  (_) => setState(() => _hovering = false),
      child: Tooltip(
        message: widget.tooltip,
        child: GestureDetector(
          onTap: widget.onPressed,
          child: AnimatedContainer(
            duration: const Duration(milliseconds: 150),
            width: 36,
            height: 36,
            decoration: BoxDecoration(
              // Highlight on hover, transparent otherwise
              color: _hovering
                  ? (widget.color ?? Colors.white).withOpacity(0.15)
                  : Colors.transparent,
              borderRadius: BorderRadius.circular(4),
            ),
            child: Icon(
              widget.icon,
              color: widget.color ?? Colors.white70,
              size: 16,
            ),
          ),
        ),
      ),
    );
  }
}