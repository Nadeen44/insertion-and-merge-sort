namespace algorithm_task
{
    public partial class Sorting : Form
    {
        public int num1;
        public int num2;
        public int num3;
        public int num4;
        public int num5;
        int[] array = new int[5];


        public Sorting()
        {
            InitializeComponent();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txt1.Text);
            num2 = int.Parse(txt2.Text);
            num3 = int.Parse(txt3.Text);
            num4 = int.Parse(txt4.Text);
            num5 = int.Parse(txt5.Text);

            array = new int[] { num1, num2, num3, num4, num5 };

            int i, j;

            for (i = 1; i < array.Length; i++)
            {
                var key = array[i];
                j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(key) > 0))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }

            string sorted_array = string.Join(" , ", array);
            label2.Text = sorted_array;


        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            array = new int[5];
            txt1.Text = " ";
            txt2.Text = " ";
            txt3.Text = " ";
            txt4.Text = " ";
            txt5.Text = " ";
            label2.Text = " ";
            label3.Text = " ";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txt1.Text);
            num2 = int.Parse(txt2.Text);
            num3 = int.Parse(txt3.Text);
            num4 = int.Parse(txt4.Text);
            num5 = int.Parse(txt5.Text);

           // array = new int[] { num1, num2, num3, num4, num5 };

            // declare an array
            int[] numbers = new int[] { num1, num2, num3, num4, num5 };

          

            //call mergeSort method
            mergeSort(numbers, 0, numbers.Length - 1);

            // loop through array after it has been sorted and print each value
            foreach (int value in numbers)
                label3.Text += value + " , " ;
        }
      
        public void mergeSort(int[] sortArray, int lower, int upper)
        {
            int middle;
            if (upper == lower)
                return;
            else
            {
                middle = (lower + upper) / 2;
                mergeSort(sortArray, lower, middle);
                mergeSort(sortArray, middle + 1, upper);
                Merge(sortArray, lower, middle + 1, upper);
            }
        }
        // Merge method will merge subarrays together incrementally
        // THIS METHOD WILL NOT WORK WITHOUT THE MERGESORT METHOD
        public void Merge(int[] sortArray, int lower, int middle, int upper)
        {
            int[] temp = new int[sortArray.Length];
            int lowEnd = middle - 1;
            int low = lower;
            int n = upper - lower + 1;

            while ((lower <= lowEnd) && (middle <= upper))
            {
                if (sortArray[lower] <= sortArray[middle])
                {
                    temp[low] = sortArray[lower];
                    low++;
                    lower++;
                }
                else
                {
                    temp[low] = sortArray[middle];
                    low++;
                    middle++;
                }
            }
            while (lower <= lowEnd)
            {
                temp[low] = sortArray[lower];
                low++;
                lower++;
            }
            while (middle <= upper)
            {
                temp[low] = sortArray[middle];
                low++;
                middle++;
            }
            for (int i = 0; i < n; i++)
            {
                sortArray[upper] = temp[upper];
                upper--;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
      
    }
    