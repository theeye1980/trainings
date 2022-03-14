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
            Thread thread = new Thread(
                delegate () { 
                


                });
            thread.Start();

            label1.Text = "dslfkjs";
        }
        void MT() { 
        
        }
    }
}