using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_app_tutorial
{
    public class TutorialManager
    {
        private readonly List<(Control control, string message)> steps;
        private int index = 0;

        public TutorialManager(List<(Control control, string message)> steps)
        {
            this.steps = steps;
        }

        public void Start()
        {
            index = 0;
            ShowCurrentStep();
        }

        private void ShowCurrentStep()
        {
            if (index >= steps.Count)
                return;

            var step = steps[index];
            index++;

            new TutorialOverlay(step.control, step.message, ShowCurrentStep).Show();
        }
    }

}
