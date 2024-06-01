using GlassFactory.Data;
using GlassFactory.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlassFactory.Forms;

public partial class CustomerList : Form
{
    private readonly AppDbContext _db;
    private int pageSize = 20;
    private int pageNumber = 1;
    private int pageCount = 0;
    private bool isUpdate = false;

    public CustomerList()
    {
        InitializeComponent();
        _db = new AppDbContext();
    }

    private void CustomerList_Load(object sender, EventArgs e)
    {
        ReBindData(pageNumber, pageSize);
        numericUpDown1.Value = pageNumber;
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(NameTextBox.Text))
        {
            MessageBox.Show("Please enter name");
            return;
        }
        try
        {
            if (isUpdate)
            {
                var customerId = int.Parse(IdTextBox.Text);
                var customer = _db.Customers.Find(customerId);
                if (customer != null)
                {
                    customer.Name = NameTextBox.Text;
                    customer.Email = EmailTextBox.Text;
                    customer.PhoneNumber = PhoneTextBox.Text;
                    customer.Note = NoteTextBox.Text;
                    _db.SaveChanges();
                    ClearTextBoxes();
                    ReBindData(pageNumber, pageSize);
                    isUpdate = false;
                }
            }
            else
            {
                var newCustomer = new Customer
                {
                    Name = NameTextBox.Text,
                    Email = EmailTextBox.Text,
                    PhoneNumber = PhoneTextBox.Text,
                    Note = NoteTextBox.Text,
                };
                _db.Customers.Add(newCustomer);
                _db.SaveChanges();
                ClearTextBoxes();
                ReBindData(pageNumber, pageSize);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void ReBindData(int pageNumber, int pageSize)
    {
        var resultsCount = _db.Customers.Count();
        pageCount = (int)Math.Ceiling((double)resultsCount / pageSize);
        nunberOfPagesmLabel.Text = pageCount.ToString();
        if (pageNumber > pageCount)
        {
            pageNumber = 1;
        }
        int skip = pageSize * (pageNumber - 1);
        int take = pageSize;
        dataGridView1.DataSource = null;
        dataGridView1.DataSource = _db.Customers.AsNoTracking().Skip(skip).Take(take).Select(x =>
        new
        {
            Id = x.CustomerID,
            Name = x.Name,
            Email = x.Email,
            PhoneNumber = x.PhoneNumber,
            Note = x.Note,
        }).ToList();
    }

    private void nextPageBtn_Click(object sender, EventArgs e)
    {
        if (pageNumber < pageCount)
        {
            pageNumber++;
            numericUpDown1.Value = pageNumber;
            prevPageBtn.Enabled = true;
            if (pageNumber == pageCount)
            {
                nextPageBtn.Enabled = false;
            }
            ReBindData(pageNumber, pageSize);
        }
    }

    private void prevPageBtn_Click(object sender, EventArgs e)
    {
        if (pageNumber > 1)
        {
            pageNumber--;
            numericUpDown1.Value = pageNumber;
            nextPageBtn.Enabled = true;
            if (pageNumber == 1)
            {
                prevPageBtn.Enabled = false;
            }
            ReBindData(pageNumber, pageSize);
        }
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            var row = dataGridView1.Rows[e.RowIndex];
            var customerId = (int)row.Cells["Id"].Value;
            var customer = _db.Customers.Find(customerId);
            if (customer != null)
            {
                IdTextBox.Text = customer.CustomerID.ToString();
                NameTextBox.Text = customer.Name;
                EmailTextBox.Text = customer.Email;
                PhoneTextBox.Text = customer.PhoneNumber;
                NoteTextBox.Text = customer.Note;
                AddButton.Text = "Update";
                isUpdate = true;
            }
        }
    }

    private void ClearButton_Click(object sender, EventArgs e)
    {
        ClearTextBoxes();
    }

    private void ClearTextBoxes()
    {
        AddButton.Text = "Add";
        isUpdate = false;
        IdTextBox.Text = "";
        NameTextBox.Text = "";
        EmailTextBox.Text = "";
        PhoneTextBox.Text = "";
        NoteTextBox.Text = "";
    }
}