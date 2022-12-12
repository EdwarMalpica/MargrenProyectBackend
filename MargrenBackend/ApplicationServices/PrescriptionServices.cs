using Margren.Domain.Entities;
using Margren.Domain.Repositories;
using Margren.Domain.ValueObjects;
using MargrenBackend.Commands;

namespace MargrenBackend.ApplicationServices
{

    public class PrescriptionServices
    {
        private readonly IPrescriptionRepository prescriptionRepository;
        private readonly IStepRepository stepRepository;
        private readonly IIngredientRepository ingredientRepository;

        public PrescriptionServices(IPrescriptionRepository prescriptionRepository, IStepRepository stepRepository, IIngredientRepository ingredientRepository)
        {
            this.prescriptionRepository = prescriptionRepository;
            this.stepRepository = stepRepository;
            this.ingredientRepository = ingredientRepository;
        }

        //RECETAS
        public async Task<ContentResponse> HandleCommand(CreatePrescriptionCommand createPrescription)
        {
            var prescription = new Prescription();
            prescription.id_prescription = createPrescription.id_prescription;
            prescription.type_prescription = PrescriptionType.create(createPrescription.type_prescription);
            prescription.name = PrescriptionName.create(createPrescription.name);
            prescription.difficulty = PrescriptionDifficulty.create(createPrescription.difficulty);
            prescription.time = PrescriptionTime.create(new TimeSpan(createPrescription.hour, createPrescription.minute, createPrescription.seconds));
            await prescriptionRepository.AddPrescription(prescription);
            return ContentResponse.createResponse(true, "Se ha creado la receta", prescription);
        }

        public async Task<ContentResponse> GetPrescriptionById(int id)
        {
            var response = await prescriptionRepository.GetPrescriptionById(PrescriptionId.create(id));
            return ContentResponse.createResponse(true, "Se encontro la receta", response);
        }

    }
}
