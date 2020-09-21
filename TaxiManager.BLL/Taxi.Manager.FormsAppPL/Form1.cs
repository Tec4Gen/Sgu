using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiManager.BLL;
using TaxiManager.Entities;

namespace Taxi.Manager.FormsAppPL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CarLogic _carLogic = new CarLogic();
        DriverLogic _driverLogic = new DriverLogic();
        WorkItemLogic _workItemLogic = new WorkItemLogic();

        public void GridViewClient(IEnumerable<Driver> driver)
        {
            dataGridDriver.Rows.Clear();

            foreach (var item in driver)
            {
                dataGridDriver.Rows.Add(item.Id, item.FistName, item.MiddleName, item.LastName);
            }
        }

        public void GridViewCar(IEnumerable<Car> car)
        {
            dataAuto.Rows.Clear();

            foreach (var item in car)
            {
                dataAuto.Rows.Add(item.Id, item.Mark);
            }
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            string TextLastName = textLastName.Text;
            string TextFirstName = textFirstName.Text;
            string TextMiddleName = textMiddleName.Text;

            if (!String.IsNullOrEmpty(TextLastName)|| !String.IsNullOrEmpty(TextFirstName) || !String.IsNullOrEmpty(TextMiddleName)) 
            {
                _driverLogic.Add(new Driver 
                {
                    
                    FistName = TextFirstName,
                    LastName = TextLastName,
                    MiddleName = TextMiddleName
                });

                var driver = _driverLogic.GetAll();

                if (driver == null)
                    return;

                GridViewClient(driver);
            }
        }

        private void btnDeleteDriver_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textIdDriver.Text, out int id))
            {
                var driver = _driverLogic.GetAll();
                _driverLogic.DeleteById(id);
                GridViewClient(driver);
            }
        }

        private void btnShowAllDriver_Click(object sender, EventArgs e)
        {
            var driver = _driverLogic.GetAll();

            if (driver == null)
                return;
            GridViewClient(driver);


        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            string TextMark = textMark.Text;
            

            if (!String.IsNullOrEmpty(TextMark))
            {
                _carLogic.Add(new Car
                {
                    Mark = TextMark,
                    
                });

                var car = _carLogic.GetAll();

                if (car == null)
                    return;

                GridViewCar(car);
            }
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textIdCar.Text, out int id))
            {
                var car = _carLogic.GetAll();
                _carLogic.DeleteById(id);
                GridViewCar(car);
            }
        }

        private void btnShowAllCar_Click(object sender, EventArgs e)
        {
            var car = _carLogic.GetAll();

            if (car == null)
                return;
            GridViewCar(car);


        }
    }
}
