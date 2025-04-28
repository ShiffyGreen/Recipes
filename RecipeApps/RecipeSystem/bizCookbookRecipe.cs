using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
   public class bizCookbookRecipe : bizObject<bizCookbookRecipe>
    {
        public bizCookbookRecipe()
        {

        }

        private int _cookbookrecipeid;
        private int _cookbookid;
        private int _recipeid;
        private int _sequencenumber;
        private string _recipename;
        private int _caloriecount;
        private DateTime? _datepublished;
        private Boolean _vegan;

        public List<bizCookbookRecipe> GetListByCookbookId(int cookbookid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(this.GetSprocName);
            SQLUtility.SetParamValue(cmd, "CookbookId", cookbookid);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListDataTable(dt);
        }

        public int CookbookRecipeId
        {
            get { return _cookbookrecipeid; }
            set
            {
                if (_cookbookrecipeid != value)
                {
                    _cookbookrecipeid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int CookbookId
        {
            get { return _cookbookid; }
            set
            {
                if (_cookbookid != value)
                {
                    _cookbookid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int RecipeId
        {
            get { return _recipeid; }
            set
            {
                if (_recipeid != value)
                {
                    _recipeid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int SequenceNumber
        {
            get { return _sequencenumber; }
            set
            {
                if (_sequencenumber != value)
                {
                    _sequencenumber = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string RecipeName
        {
            get { return _recipename; }
            set
            {
                if (_recipename != value)
                {
                    _recipename = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int CalorieCount
        {
            get { return _caloriecount; }
            set
            {
                if (_caloriecount != value)
                {
                    _caloriecount = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime? DatePublished
        {
            get { return _datepublished; }
            set
            {
                if (_datepublished != value)
                {
                    _datepublished = value;
                    InvokePropertyChanged();
                }
            }
        }

        public Boolean Vegan
        {
            get { return _vegan; }
            set
            {
                if (_vegan != value)
                {
                    _vegan = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
