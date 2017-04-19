using Kitchen.Contracts;

namespace Kitchen.Models
{
    internal class Carrot : IIngredient
    {
        private bool isCut;
        private bool isPeeled;
        private bool isRotten;

        public Carrot()
        {
            this.IsCut = false;
            this.IsPeeled = false;
            this.IsRotten = false;
        }

        public bool IsCut
        {
            get
            {
                return this.isCut;
            }

            set
            {
                this.isCut = value;
            }
        }

        public bool IsPeeled
        {
            get
            {
                return this.isPeeled;
            }

            set
            {
                this.isPeeled = value;
            }
        }

        public bool IsRotten
        {
            get
            {
                return this.isRotten;
            }

            set
            {
                this.isRotten = value;
            }
        }
    }
}
