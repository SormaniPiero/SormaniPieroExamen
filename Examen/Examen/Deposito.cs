using System;


//namespace EDexamenT6a8


namespace Deposito
{
    /*Clase que representa la gestión de los depósitos de una granja.
     * Tiene dos depósitos: pienso y agua. 
     * La propiedad devuelve el nivel de agua y pienso. 
     * Los métodos permiten reponer o consumir tanto pienso como agua.
     * Estos comentarios se deben eliminar y usar comentarios de documentación en su lugar.
     */

    /// <summary>
    /// La primera refactorizacion que voy a hacer es espaciar
    /// todo el proyecto.
    /// 
    /// En las variables he refactorizado cambiando el nombre
    /// de las variables.
    /// 
    /// 
    /// </summary>
    class Deposito
    {
        private decimal nivelAgua;
        private decimal nivelPienso;
        private decimal cantidadMaxAgua;      //La cantidad máxima a reponer no puede superar el tamaño del DEPÓSITO DE AGUA, se comprueba antes de actualizar los niveles. 
        private decimal cantidadMaxPienso;     //La cantidad máxima a reponer no puede superar el tamaño del DEPÓSITO DE PIENSO, se comprueba antes de actualizar los niveles. 

        public decimal Niveldeagua
        {
            get { return nivelAgua; }
        }


        public decimal Niveldepienso
        {
            get { return nivelPienso; }
        }

        /// <summary>
        /// En esta función he tenido que quitar el punto y coma
        /// después del if
        /// </summary>
        /// <remark>Si no se hubiese corregido ese error, el programa podría haber fallado</remark>

        public void reponerAgua(decimal cantidadReponerAgua)
        {

            cantidadMaxAgua = cantidadReponerAgua + nivelAgua;
            if (cantidadReponerAgua > 0 && cantidadMaxAgua < 10000)   //Tamaño del depósito de pienso es de 1000 l.
            nivelAgua = nivelAgua + cantidadReponerAgua;

        }


        public void reponerPeinso(decimal cantidadReponerAgua)
        {
            //Tamaño del depósito de pienso es de 5000 kg. 
            cantidadMaxPienso = cantidadReponerAgua + nivelPienso;
            if (cantidadReponerAgua > 0 && cantidadMaxPienso < 5000)  
                nivelPienso = nivelPienso + cantidadReponerAgua;

        }


        public decimal consumoAgua(decimal cantidadRetirarAgua)
        {
            decimal retAgua = 0; //Cantidad que se retira
            retAgua = calElementos(cantidadRetirarAgua, retAgua);

            return retAgua;
        }


        public decimal consumoPienso(decimal cantidadRetirarPienso)
        {
            decimal retPienso = 0; //Cantidad que se retira
            retPienso = calElementos(cantidadRetirarPienso, retPienso);

            return retPienso;
        }

        private decimal calElementos(decimal cantidadRetirarPienso, decimal retPienso)
        {
            if (cantidadRetirarPienso > 0 && cantidadRetirarPienso <= nivelPienso)
            {
                retPienso = cantidadRetirarPienso;
                nivelPienso = nivelPienso - cantidadRetirarPienso;
            }

            return retPienso;
        }
    }
}