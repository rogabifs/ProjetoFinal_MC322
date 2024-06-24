using HelloWorld.Model;
using HelloWorld.ViewModel;
using ProjetoFinal_MC322.Model;
using ProjetoFinal_MC322.ViewModel;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Create Hotel Model and View Model
        HotelModel hotelModel = new HotelModel();
        HotelViewModel hotelViewModel = new HotelViewModel(hotelModel);

        // Add some rooms to the hotel (assuming you have a method for this)
        hotelModel.AdicionarQuarto(new QuartoModel(101, "Simples", true));
        hotelModel.AdicionarQuarto(new QuartoModel(102, "Duplo", true));
        hotelModel.AdicionarQuarto(new QuartoModel(103, "Duplo", false));

        int numeroClientes = 1;

        for (int i = 0; i < numeroClientes; i++)
        {
            // Prepare a new client view model for user input
            ClienteModel clienteModel = new ClienteModel();
            ClienteViewModel clienteViewModel = new ClienteViewModel(clienteModel);

            Console.WriteLine("Bem vindo ao HotelX" + "\n" + "Por favor preencha sua fixa cadastral");
            Console.Write("Nome = ");
            clienteViewModel.Nome = Console.ReadLine();

            Console.Write("Idade = ");
            string? idadeInput = Console.ReadLine();
            int idade;
            int.TryParse(idadeInput, out idade);
            clienteViewModel.Idade = idade;

            Console.Write("CPF = ");
            string? cpfInput = Console.ReadLine();
            int cpf;
            int.TryParse(cpfInput, out cpf);
            clienteViewModel.Cpf = cpf;

            // Convert ViewModel to Model and add to Hotel Model
            clienteModel = clienteViewModel.setClienteModel();
            hotelModel.GetClientes().Add(clienteModel);
        }

        // Loop through clients and handle room selection/reservation using ViewModel
        for (int i = 0; i < hotelModel.Clientes.Count; i++)
        {
            ClienteModel clienteModel = hotelModel.Clientes[i];
            ClienteViewModel clienteViewModel = new ClienteViewModel(clienteModel);

            Console.WriteLine($"Cliente {i + 1} escolha um dos quartos disponiveis pelo numero");
            //for loop to print all available rooms
            for (int j = 0; j < hotelViewModel.QuartosDisponiveis.Count; j++)
            {
                Console.WriteLine(hotelViewModel.QuartosDisponiveis[j]);
            }

            Console.Write("\nDigite aqui o número do quarto da sua reserva: ");
            string? numeroReservaINPUT = Console.ReadLine();
            int numeroReserva;
            int.TryParse(numeroReservaINPUT, out numeroReserva);

            string format = "dd/MM/yyyy HH:mm";
            Console.Write($"\nAgora digite a data do seu checkIN e do seu checkOUT\n com o formato {format}");

            Console.Write("\ncheckIN: ");
            string? checkInINPUT = Console.ReadLine();
            DateTime checkIn;
            DateTime.TryParseExact(checkInINPUT, format, null, DateTimeStyles.None, out checkIn);

            Console.Write("\ncheckOUT: ");
            string? checkOutINPUT = Console.ReadLine();
            DateTime checkOut;
            DateTime.TryParseExact(checkOutINPUT, format, null, DateTimeStyles.None, out checkOut);

            // Use HotelViewModel method with client information
            hotelViewModel.ReservarQuarto(clienteViewModel, numeroReserva, checkIn, checkOut);
        }


    }
}

