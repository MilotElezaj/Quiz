namespace Quiz___Milot_Elezaj
{
    public partial class Form1 : Form
    {
        //Kuizi per njohuri
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 8;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }
            if (questionNumber == totalQuestions)
            {
                percentage = (score * 100) / totalQuestions;
                MessageBox.Show("Ju faleminderit per pjesmarrjen tuaj ne kete kuiz. Ju keni arritur " + percentage + "% te sakta.");

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }

            questionNumber++;
            askQuestion(questionNumber);
        }
        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.oop;
                    lblQuestion.Text = "Cfare do te thote OOP";
                    btn1.Text = "Object Oriented Programming";
                    btn2.Text = "Object Oriented Projecting";
                    btn3.Text = "Object Organizing Planning";
                    btn4.Text = "Executed Programming";

                    correctAnswer = 1;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.programming;
                    lblQuestion.Text = "Cila eshte gjuha e programimit me e perdorur ne boten e programimit";
                    btn1.Text = "Java";
                    btn2.Text = "C#";
                    btn3.Text = "Python";
                    btn4.Text = "C++";
                    correctAnswer = 2;
                    break;
                case 3:
                   pictureBox1.Image = Properties.Resources.crud;
                    lblQuestion.Text = "Cfare do te thote CRUD";
                    btn1.Text = "Create Read Update Delete";
                    btn2.Text = "Create Read Undo Delete";
                    btn3.Text = "Create Read Undo Data";
                    btn4.Text = "Create Read Update Data";
                    correctAnswer = 1;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.uk;
                    lblQuestion.Text = "What does the reported speech mean?";
                    btn1.Text = "When we move one tense back";
                    btn2.Text = "When we move one tense forward";
                    btn3.Text = "When something is happenning right now";
                    btn4.Text = "When something happened before";
                    correctAnswer = 1;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.web;
                    lblQuestion.Text = "What does HTML mean?";
                    btn1.Text = "High Text Madeup Language";
                    btn2.Text = "Hiherarchical Text Markup Language";
                    btn3.Text = "Hyper Text Markup Language";
                    btn4.Text = "Hyper Text Madeup Learning";
                    correctAnswer = 3;
                    break;
                case 6: 
                    pictureBox1.Image = Properties.Resources.web;
                    lblQuestion.Text = "Qfare do te thote CSS?";
                    btn1.Text = "Computer Style System";
                    btn2.Text = "Code Styling Structure";
                    btn3.Text = "Creative Styling Software";
                    btn4.Text = "Cascading Style Sheet";
                    correctAnswer = 4;
                break;
                case 7:
                    pictureBox1.Image = Properties.Resources.programming;
                    lblQuestion.Text = "Çfarë bën komanda INNER JOIN në SQL";
                    btn1.Text = "Bashkon të gjitha rreshtat nga dy tabela, përfshirë edhe ato që nuk përputhen";
                    btn2.Text = "Kthen vetëm rreshtat që kanë vlera te perbashketa në të dy tabelat";
                    btn3.Text = "Fshin rreshtat e përsëritur nga tabelat e bashkuara";
                    btn4.Text = "Bashkon tabela pa përdorur ndonjë kusht";
                    correctAnswer = 2;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.programming;
                    lblQuestion.Text = "Cili nga opsionet më poshtë përshkruan saktë një  Entity në një databaze?";
                    btn1.Text = " Një entitet është një atribut që identifikon një objekt specifik në një bazë të dhënash.";
                    btn2.Text = "Një entitet është një lloj i veçantë i tabelës që përmban të dhëna për një kategori të caktuar";
                    btn3.Text = "Një entitet është një objekt ose një person që mund të jetë i veçantë dhe që përmban informacion të caktuar në një bazë të dhënash.";
                    btn4.Text = "Një entitet është një lidhje mes dy ose më shumë tabelash në një bazë të dhënash.";
                    correctAnswer = 3;
                    break;

            }
        }
    }
}
