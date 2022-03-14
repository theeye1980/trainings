namespace trainings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            M();
            label1.Text = "sdfsad";
        }

        async void M(){
          await Task.Run(() => {
                
                
          });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // CheckForIllegalCrossThreadCalls = false; // делает возможность между потоками творить что угодно

            Thread thread = new Thread(
                delegate () {

                    //Invoke
                    //MT(label1);

                    /*
                     //запуск делегата с помощью Action
                    */
                    Action action = () => {
                        label1.Text = "Смета по Action";
                    };
                    if (InvokeRequired)
                    {
                        Invoke(action);
                    }
                    else {
                        action();
                    }
                });
            thread.Start();

            
        }
        void MT(Label label) {
            label.Text="fgklasjdgo";
        }
    }
}