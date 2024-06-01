using GlassFactory.Data;
using GlassFactory.Data.Model;

namespace GlassFactory
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext _db;

        public Form1()
        {
            InitializeComponent();
            _db = new AppDbContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var newCustomer = new Customer
            {
                Name = NameTextBox.Text,
                Email = EmailTextBox.Text,
                PhoneNumber = PhoneTextBox.Text,
            };
            _db.Customers.Add(newCustomer);
            _db.SaveChanges();
        }

        //private void PrintLabel(Piece piece)
        //{
        //	// Assuming using a Zebra printer and the Zebra SDK
        //	string labelContent = $"Length: {piece.Length}, Width: {piece.Width}, CustomerID: {piece.CustomerID}";
        //	// Add code here to send the labelContent to the printer
        //}
    }
}