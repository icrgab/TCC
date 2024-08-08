using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace test_v01.Repository.Models;

[Table("usuario")]
public partial class Usuario
{
    [Key]
    [Column("idusuario")]
    public int Idusuario { get; set; }

    [Column("emailusuario")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Emailusuario { get; set; }

    [Column("senhausuario")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Senhausuario { get; set; }

    [Column("recmail")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Recmail { get; set; }

    [Column("nomeusuario")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Nomeusuario { get; set; }

    [Column("telefoneusuario")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Telefoneusuario { get; set; }

    [InverseProperty("IdusuarioNavigation")]
    public virtual ICollection<Documento> Documentos { get; set; } = new List<Documento>();
}
