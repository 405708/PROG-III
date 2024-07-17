﻿using secondParcialWebAPI.Models;

namespace secondParcialWebAPI.DTOS
{
    public class SocioAltaDto
    {
        public Guid Id { get; set; }

        public string Email { get; set; } = null!;

        public bool Activo { get; set; }

        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public string Dni { get; set; } = null!;

        public Guid IdDeporte { get; set; }

        public string? Telefono { get; set; }

        public string? Calle { get; set; }

        public string? Numero { get; set; }

        public string? CodPost { get; set; }

        public string? Provincia { get; set; }

        public string? Ciudad { get; set; }

        public DateTime? FechaAlta { get; set; }
    }
}
