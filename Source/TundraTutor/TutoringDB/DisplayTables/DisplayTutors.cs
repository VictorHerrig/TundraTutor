﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayTables
{
    public partial class DisplayTutors : Form
    {
        public DisplayTutors()
        {
            InitializeComponent();
        }
        //Entity Framework DbContext
        private TutoringDB.TutorDatabaseEntities dbcontext = new TutoringDB.TutorDatabaseEntities();
        private void DisplayTutors_Load(object sender, EventArgs e)
        {
            dbcontext.Tutors
                .OrderBy(tutor => tutor.LastName)
                .ThenBy(tutor => tutor.FirstName)
                .Load();

            //specify DataSource for tutorBindingSource
            tutorBindingSource.DataSource = dbcontext.Tutors.Local;
        }

        private void tutorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            tutorBindingSource.EndEdit();
            try
            {
                dbcontext.SaveChanges();
            }
            catch (DbEntityValidationException)
            {
                MessageBox.Show("All Fields must contain values", "Entity Validation Exception");
            }
        }
    }
    

    //load data from database into DataGridView
}
