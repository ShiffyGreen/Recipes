using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class bizCookbookList : bizObject<bizCookbookList>
    {
        public bizCookbookList()
        {

        }

        private int _cookbookId;
        private string _cookbookname;
        private string _username;
        private int _numofrecipes;
        private string _skilllevel;

        public int CookbookId
        {
            get { return _cookbookId; }
            set
            {
                if (_cookbookId != value)
                {
                    _cookbookId = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string CookbookName
        {
            get { return _cookbookname; }
            set
            {
                if (_cookbookname != value)
                {
                    _cookbookname = value;
                    InvokePropertyChanged();
                }
            }
        }
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
        public int NumofRecipes
        {
            get { return _numofrecipes; }
            set
            {
                if (_numofrecipes != value)
                {
                    _numofrecipes = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string SkillLevel
        {
            get { return _skilllevel; }
            set
            {
                if (_skilllevel != value)
                {
                    _skilllevel = value;
                    InvokePropertyChanged();
                }
            }
        }

    }
}
