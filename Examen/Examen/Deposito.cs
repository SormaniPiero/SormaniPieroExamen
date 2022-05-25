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
        private decimal niveldeagua;
        private decimal niveldepienso;
        private decimal cantidadMaxAgua;      //La cantidad máxima a reponer no puede superar el tamaño del DEPÓSITO DE AGUA, se comprueba antes de actualizar los niveles. 
        private decimal cantidadMaxPienso;     //La cantidad máxima a reponer no puede superar el tamaño del DEPÓSITO DE PIENSO, se comprueba antes de actualizar los niveles. 

        public decimal Niveldeagua
        {
            get { return niveldeagua; }
        }


        public decimal Niveldepienso
        {
            get { return niveldepienso; }
        }

        /// <summary>
        /// En esta función he tenido que quitar el punto y coma
        /// antes del if
        /// </summary>
        public void reponerAgua(decimal cantidadareponerdeagua)
        {

            cantidadMaxAgua = cantidadareponerdeagua + niveldeagua;
            if (cantidadareponerdeagua > 0 && cantidadMaxAgua < 10000)   //Tamaño del depósito de pienso es de 1000 l.
            niveldeagua = niveldeagua + cantidadareponerdeagua;

        }

        public void reponerPeinso(decimal cantidadareponerdepienso)
        {

            cantidadMaxPienso = cantidadareponerdepienso + niveldepienso;
            if (cantidadareponerdepienso > 0 && cantidadMaxPienso < 5000)  //Tamaño del depósito de pienso es de 5000 kg. 
                niveldepienso = niveldepienso + cantidadareponerdepienso;

        }


        public decimal consumoAgua(decimal cantidadaretirardeagua)
        {
            decimal retirado1 = 0; //Cantidad que se retira
            if (cantidadaretirardeagua > 0 && cantidadaretirardeagua <= niveldeagua)
            {
                retirado1 = cantidadaretirardeagua;
                niveldeagua = niveldeagua - cantidadaretirardeagua;
            }

            return retirado1;
        }

        public decimal consumoPienso(decimal cantidadaretirardepienso)
        {
            decimal retirado2 = 0; //Cantidad que se retira
            if (cantidadaretirardepienso > 0 && cantidadaretirardepienso <= niveldepienso)
            {
                retirado2 = cantidadaretirardepienso;
                niveldepienso = niveldepienso - cantidadaretirardepienso;
            }

            return retirado2;
        }

    }
}