using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebElReyCan.Models;
using WebElReyCan.Data;

namespace WebElReyCan.Admin
{
    public class AdmTurno
    {
        static TurnoDbContext context = new TurnoDbContext();

        public static List<Turno> Listar()
        {
            return context.Turnos.ToList();
        }

        public static void Insertar(Turno turno)
        {
            context.Turnos.Add(turno);
            context.SaveChanges();
        }

        public static Turno TraerPorID(int id)
        {
            Turno turno = context.Turnos.Find(id);
            context.Entry(turno).State = EntityState.Detached;
            return turno;
        }

        public static void Eliminar(Turno turno)
        {
            if (!context.Turnos.Local.Contains(turno))
            {
                context.Turnos.Attach(turno);
                context.Turnos.Remove(turno);
                context.SaveChanges();
            }
        }

        public static List<Turno> ListarTurno(string nombreMascota)
        {
            var turnos = (from v in context.Turnos
                          where v.NombreMascota == nombreMascota
                          select v).ToList();
            return turnos;
        }

        public static void Editar(Turno turno)
        {
            context.Turnos.Attach(turno);
            context.Entry(turno).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}