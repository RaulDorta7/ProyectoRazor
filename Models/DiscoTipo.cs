﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ProyectoRazorFinal.Models
{
    public partial class DiscoTipo
    {
        public int Id { get; set; }
        public int IdDisco { get; set; }
        public int IdTipo { get; set; }

        public virtual Disco IdDiscoNavigation { get; set; }
        public virtual Tipo IdTipoNavigation { get; set; }
    }
}