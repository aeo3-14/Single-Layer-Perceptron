namespace single_layer_perceptron
{
    public partial class Perceptron : Form
    {

        double w1, w2, bias;
        double x1, x2;
        double learning_rate;
        int output;
        int[] desired;
        int[,] patterns;
        Random rnd;
       // double MIN_VALUE = -0.5;
      //  double MAX_VALUE = 0.5;

        public Perceptron()
        {
            InitializeComponent();
        }

        private void starttrain_Click(object sender, EventArgs e)
        {
            double y, delta;
            int max_epoch = 1000000, epochs = 1;
            int error = 10;
            int pn;
            int[] pat_used = new int[4]; //monitor the pattern
             
            FileStream f1 = new FileStream("output.csv", FileMode.OpenOrCreate);
            StreamWriter s1 = new StreamWriter(f1);
            if(logicGate.Text=="AND")
            {
                s1.WriteLine("AND");
            }
            else
            {
                s1.WriteLine("OR");
            }
            
            s1.WriteLine("x1,x2,Yd,w1,w2,y,output,delta,updated w1,updated w2,error,epoch");
            while (error > 0 && epochs < max_epoch)
            {
                error = 0;
                for(int i = 0;i < 4; i++)
                { 
                      x1 = patterns[i, 0];
                      s1.Write( x1 + ",");
                      x2 = patterns[i, 1];
                      s1.Write(x2 + ",");
                      y = x1 * w1 + x2 * w2 + bias;
                     // s1.Write(y + ",");
                      if (y >= 0) output = 1;
                      else output = 0;
                      s1.Write(desired[i] + ",");
                      s1.Write(w1 + ",");
                      s1.Write(w2 + ",");
                      s1.Write(y + ",");
                      s1.Write(output + ",");

                      delta = desired[i] - output; 
                      s1.Write(delta + ",");
                      if (delta != 0)
                      {
                        w1 += learning_rate * delta * x1;
                        s1.Write( w1 + ",");
                        w2 += learning_rate * delta * x2;
                        s1.Write(w2 + ",");
                        bias += learning_rate * delta;
                      }
                      else
                      {
                        s1.Write(w1 + ",");
                        s1.Write(w2 + ",");
                      }
                     error += Math.Abs((int)delta);
                     s1.Write(error + ",");
                     s1.Write(epochs+ ",");
                     s1.WriteLine();


                }
                epochs++;
            }
          
            s1.Close();
            f1.Close();
            directory.Visible = true;
            MessageBox.Show("Finished!\nEpochs: " + epochs + "\nErrors: " + error);
        }

        private void loadData_Click(object sender, EventArgs e)
        {
            rnd = new Random();
            // w1 = rnd.NextDouble() * (MAX_VALUE - MIN_VALUE) + MIN_VALUE;
            //  w2 = rnd.NextDouble() * (MAX_VALUE - MIN_VALUE) + MIN_VALUE;
            // w1 = -0.4;
            // w2 = 0.1;
            w1 = rnd.NextDouble();
            w2 = rnd.NextDouble();
            learning_rate = 0.1;
            bias = rnd.NextDouble();
           // bias = 0.2;
            patterns = new int[4, 2];
            desired = new int[4];
            patterns[0, 0] = 0;
            patterns[0, 1] = 0;
            patterns[1, 0] = 0;
            patterns[1, 1] = 1;
            patterns[2, 0] = 1;
            patterns[2, 1] = 0;
            patterns[3, 0] = 1;
            patterns[3, 1] = 1;

            if (loadData.Text=="LOAD DATA")
            {
                loadData.Text = "DATA IS LOADED";
                loadData.BackColor = Color.Black;

                

                if (logicGate.Text == "AND")
                {
                    desired[0] = 0;
                    desired[1] = 0;
                    desired[2] = 0;
                    desired[3] = 1;
                }
                else
                {
                    desired[0] = 0;
                    desired[1] = 1;
                    desired[2] = 1;
                    desired[3] = 1;
                }
            }
            else if(loadData.Text == "DATA IS LOADED")
            {
                loadData.Text = "LOAD DATA";
                loadData.BackColor = Color.FromArgb(0,64,64);

                 

                if (logicGate.Text == "AND")
                {
                    desired[0] = 0;
                    desired[1] = 0;
                    desired[2] = 0;
                    desired[3] = 1;
                }
                else if(logicGate.Text == "OR")
                {
                    desired[0] = 0;
                    desired[1] = 1;
                    desired[2] = 1;
                    desired[3] = 1;
                }
            }
            trainingdes.Text =logicGate.Text+" Logic Gate Single Layer Perceptron";
            trainingdes.Visible = true;
           
            
        
           
        }

        private void testData_Click(object sender, EventArgs e)
        {
          
            double v;
            if (w1>=0 && w2>=0 && bias >=0 && input1.Text!=null&& input2.Text != null)
            {
                x1 = Convert.ToInt32(input1.Text);
                x2 = Convert.ToInt32(input2.Text);

                v = x1 * w1 + x2 * w2 + bias;
                if (v >= 0) testOutput.Text = "1";
                else testOutput.Text = "0";
            }
            else if(input1.Text == null && input2.Text == null)
            {
                MessageBox.Show("Input a value in input 1 and input 2");
            }
            else
            {
                MessageBox.Show("click LOAD DATA first to load the data");
            }

            
         
        }
    }
}