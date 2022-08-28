using WFAEntity270822A.Classes;

namespace WFAEntity270822A
{
    public partial class Form1 : Form
    {
        private readonly AppDBContext _context;

        public Form1(AppDBContext context)
        {
            InitializeComponent();
            this._context = context;

            //grades e 100 e kadar ekledik.
            for (int i = 12; i <=100; i++)
            {
                Grade grade = new Grade();
                grade.Value = i;
                _context.Grades.Add(grade);
                _context.SaveChanges();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}