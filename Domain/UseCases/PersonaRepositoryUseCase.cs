using Domain.Entities;
using Domain.RepositoriesInterfaces;


namespace Domain.UseCases
{
    public class PersonaRepositoryUseCase : IPersonaRepositoryUseCase
    {
        private readonly IPersonaRepository PersonaRepository;
        public PersonaRepositoryUseCase() // INJECTION
        {
        }
       
        public List<Persona> GetListadoPersonas()
        {
            return PersonaRepository.GetListadoPersonas();
        }
    }
}