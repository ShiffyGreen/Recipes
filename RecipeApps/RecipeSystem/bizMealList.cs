using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class bizMealList :bizObject<bizMealList>
    {
        public bizMealList()
        {

        }

        private string _username;
        private string _mealname;
        private int _numcalories;
        private int _numcourses;
        private int _numrecipes;
        private string _description;

        public string UserName
        {
            get { return _username; }
            set
            {
                if (_username != value)
                {
                    _username = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string MealName
        {
            get { return _mealname; }
            set
            {
                if (_mealname != value)
                {
                    _mealname = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int NumCalories
        {
            get { return _numcalories; }
            set
            {
                if (_numcalories != value)
                {
                    _numcalories = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int NumCourses
        {
            get { return _numcourses; }
            set
            {
                if (_numcourses != value)
                {
                    _numcourses = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int NumRecipes
        {
            get { return _numrecipes; }
            set
            {
                if (_numrecipes != value)
                {
                    _numrecipes = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    InvokePropertyChanged();
                }
            }
        }


    }
}
