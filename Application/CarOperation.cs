using Domain;

namespace Application
{
    public class CarOperation
    {
        public ReservationResponse Reservation(ReservationRequest request)
        {
            var car = new Car(request.Color, request.DoorQuantity, request.Model);

            return new ReservationResponse() {Message = $"O carro foi reservado com sucesso." , OrderNumber = Guid.NewGuid()};
        }
    }
}