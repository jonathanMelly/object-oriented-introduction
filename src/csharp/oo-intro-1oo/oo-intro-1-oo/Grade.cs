using System;
using System.Collections.Generic;
using System.Text;

namespace object_oriented_introduction
{
    public class Grade
    {
        //Pour stocker la valeur de la note (entre 0 et 6)
        private float value;


        public Grade(float value)
        {
            Value = value;
        }

        public float Value
        {
            get
            {
                return value;
            }
            set
            {
                //TODO: vérifier que value est bien entre 0 et 6 ...
                this.value = value;
            }
        }
    }
}
