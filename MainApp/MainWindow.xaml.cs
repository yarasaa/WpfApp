using Business.Concrete;
using DataAccess.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace MainApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ExpenseManager expenseManager = new ExpenseManager(new EfExpenseDal());
        //List<Expense> list = new List<Expense>();
        //Expense expense1 = new Expense();
        ExpenseContext expenseContext = new ExpenseContext();
        ObservableCollection<Expense> listing = new ObservableCollection<Expense>();
        


        public MainWindow()
        {
            InitializeComponent();
            
        }

        

        private void Data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void txtLeisure_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void Data_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            foreach (var expense in expenseManager.GetAll())
            {
                listing.Add(new Expense()
                {
                    ID = expense.ID,
                    Salary = expense.Salary,
                    Car = expense.Car,
                    Clothing = expense.Clothing,
                    Food = expense.Food,
                    Leisure = expense.Leisure,
                    Living = expense.Living
                });

            }

            Data.ItemsSource = listing;

            


        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
 
            expenseManager.Add(new Expense
            {
                Salary =Convert.ToDouble(txtSalary.Text),
                Car = Convert.ToDouble(txtCar.Text),
                Clothing = Convert.ToDouble(txtClothing.Text),
                Food = Convert.ToDouble(txtFood.Text),
                Leisure = Convert.ToDouble(txtLeisure.Text),
                Living = Convert.ToDouble(txtLiving.Text),
            });
            expenseContext.SaveChanges();
            Data.Items.Refresh();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {


           
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {

            


        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (Data.SelectedItem!=null)
            {
                listing.Remove((Expense)Data.SelectedItem);
            }
        }

        //private void Data_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        //{

        //}

        //private void Data_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        //{

        //}

        //private void Data_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        //{

        //}




        //private void Data_Selected(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
