using System.ComponentModel.DataAnnotations.Schema;

namespace MockPruebaTecnica.Models
{
    public class Cliente
    {
        [Column("id_cliente")]
        public int Id { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }

        [Column("apellido")]
        public string Apellido { get; set; }

        [Column("correo_electronico")]
        public string CorreoElectronico { get; set; }

        public ICollection<Venta> Ventas { get; set; }
    }
}
