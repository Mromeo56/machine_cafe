using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_slam2_romeo_moreaux_partie2
{
    class boisson
    {
        private String intitule; 
        private String description;
        private float prix;
        private int stock;
        private int sucre;
        private bool modifSucre;
        private String chaudFroid;

        public boisson(string intitule, String description, float prix, int stock, int sucre, bool modifSucre, String chaudFroid)
        {
            this.intitule = intitule;
            this.description = description;
            this.prix = prix;
            this.stock = stock; 
            this.sucre = sucre;
            this.modifSucre = modifSucre;
            this.chaudFroid = chaudFroid;
        }

        public string getIntitule()
        {
            return (this.intitule);
        }

        public int getSucre()
        {
            return (this.sucre);
        }

        public string getDescription()
        {
            return (this.description);
        }

        public float getPrix()
        {
            return (this.prix);
        }

        public int getStock()
        {
            return (this.stock);
        }

        public string getChaudFroid()
        {
            return (this.chaudFroid);
        }

        public bool diminutionStock()
        {
            bool retour = false;
            if (stock > 1)
            {
                //this.stock = this.stock-1;
                this.stock--;
                retour = true;
            }
            else
            {
                retour = false;
            }
            return (retour);
        }
    }
}
