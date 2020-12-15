using AutoMapper;
using Entity;
using Entity.DTO;

namespace LuckyBooks.API.AutoMapper
{
    public class MappingProfileLibro : Profile
    {
        public MappingProfileLibro()
        {
            //GET: Libro y LibroDto 
            // A     =====>     //B  
            CreateMap<Libro, LibroDto>()
                .ForMember(b => b.codigolibro, opt => opt.MapFrom(a => a.id_libro))
                .ForMember(b => b.descripcion, opt => opt.MapFrom(a => a.descripcion))
                .ForMember(b => b.asignatura, opt => opt.MapFrom(a => a.asignatura))
                .ForMember(b => b.stock, opt => opt.MapFrom(a => a.stock));


            //POST: Libro y LibroForCreationDto 
            // A     =====>     //B  
            CreateMap<LibroForCreationDto, Libro>()
                  .ForMember(b => b.id_libro, opt => opt.MapFrom(a => a.codigolibro))
                .ForMember(b => b.descripcion, opt => opt.MapFrom(a => a.descripcion))
                .ForMember(b => b.asignatura, opt => opt.MapFrom(a => a.asignatura))
                .ForMember(b => b.stock, opt => opt.MapFrom(a => a.stock));


            //PUT: Libro y LibroForUpdateDto 
            // A     =====>     //B  
            CreateMap<LibroForUpdateDto, Libro>()
                  .ForMember(b => b.id_libro, opt => opt.MapFrom(a => a.codigoLibro))
                .ForMember(b => b.descripcion, opt => opt.MapFrom(a => a.descripcion))
                .ForMember(b => b.asignatura, opt => opt.MapFrom(a => a.asignatura))
                .ForMember(b => b.stock, opt => opt.MapFrom(a => a.stock));
        }
    }
}
