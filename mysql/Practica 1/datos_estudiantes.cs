using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Infotep_sn
{
    #region Datos_estudiantes
    public class Datos_estudiantes
    {
        #region Member Variables
        protected int _id;
        protected string _nombre;
        protected int _edad;
        #endregion
        #region Constructors
        public Datos_estudiantes() { }
        public Datos_estudiantes(int id, string nombre, int edad)
        {
            this._id=id;
            this._nombre=nombre;
            this._edad=edad;
        }
        #endregion
        #region Public Properties
        public virtual int Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual string Nombre
        {
            get {return _nombre;}
            set {_nombre=value;}
        }
        public virtual int Edad
        {
            get {return _edad;}
            set {_edad=value;}
        }
        #endregion
    }
    #endregion
}