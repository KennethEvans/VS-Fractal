using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fractal {
    interface IImage {
        Image Image { get; set; }
    }

    class FractalTimer<T> where T : IImage {
        private List<T> iterations;
        private PictureBox pictureBox;
        private Button button;
        private Timer timer;
        private int interval = 2000;
        private int currentImage = 0;
        private bool playing = false;

        public FractalTimer() {
        }

        public FractalTimer(List<T> iterations, PictureBox pictureBox, Button button) {
            this.iterations = iterations;
            this.pictureBox = pictureBox;
            this.button = button;
        }

        public void startTimer() {
            if (iterations == null || iterations.Count == 0) {
                Utils.Utils.errMsg("There are no items to play");
                return;
            }
            pictureBox.Image = iterations[currentImage].Image;
            timer = new Timer();
            timer.Interval = interval;
            timer.Tick += new EventHandler(OnTimerTick);
            timer.Start();
            playing = true;
            button.Text = "Pause";
        }

        public void resetTimer() {
            currentImage = 0;
            stopTimer();
        }

        public void stopTimer() {
            if (timer == null || !timer.Enabled || !playing) {
                //if (flakes != null && flakes.Count > 0) {
                //    pictureBox1.Image = flakes[flakes.Count - 1].Image;
                //}
                //buttonKochPlay.Text = "Play";
                playing = false;
                return;
            }
            if (timer != null && timer.Enabled) {
                timer.Stop();
            }
            //if (flakes != null && flakes.Count > 0) {
            //    pictureBox1.Image = flakes[flakes.Count - 1].Image;
            //}
            button.Text = "Play";
            playing = false;
        }

        private void OnTimerTick(object sender, EventArgs e) {
            if (++currentImage >= iterations
                .Count) currentImage = 0;
            pictureBox.Image = iterations[currentImage].Image;
        }

        public List<T> Iterations { get => iterations; set => iterations = value; }
        public PictureBox PictureBox { get => pictureBox; set => pictureBox = value; }
        public Button Button { get => button; set => button = value; }
        public int Interval { get => interval; set => interval = value; }
        public int CurrentImage { get => currentImage; set => currentImage = value; }
        public bool Playing { get => playing; set => playing = value; }
    }
}
