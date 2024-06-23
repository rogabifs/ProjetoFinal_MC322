using System;
using System.Globalization;

class Program
{
    static void Main(){
        
        Hotel hotel = new Hotel(); // Criando uma instância de Hotel
        Quarto quarto1 = new Quarto(101, "Simples",true);
        Quarto quarto2 = new Quarto(102, "Duplo",true);
        Quarto quarto3 = new Quarto(103, "Duplo",false);
        
        hotel.AdicionarQuarto(quarto1);
        hotel.AdicionarQuarto(quarto2);
        hotel.AdicionarQuarto(quarto3);

        
        int numeroClientes = 1;
        for (int i =0; i<numeroClientes;i++){
            Console.WriteLine("Bem vindo ao HotelX"+"\n"+"Por favor preencha sua fixa cadastral");
            Console.Write("Nome = ");
            string? nome = Console.ReadLine();
            
            Console.Write("Idade = ");
            string? idadeInput = Console.ReadLine();
            int idade;
            int.TryParse(idadeInput,out idade);
            
            Console.Write("CPF = ");
            string? cpfInput = Console.ReadLine();
            int cpf;
            int.TryParse(cpfInput,out cpf);
            
            Cliente cliente = new Cliente();
            cliente.SetIdade(idade);
            cliente.SetCpf(cpf);
            if (nome !=null){
            cliente.SetNome(nome);
            }
            
            hotel.GetClientes().Add(cliente);
        }
        

        for (int i = 0;i<hotel.GetClientes().Count; i++){
            Console.WriteLine($"Cliente {i+1} escolha um dos quartos disponiveis pelo numero");
            Console.WriteLine(hotel.ToStringQuartosDisponiveis());

            Console.Write("\nDigite aqui o número do quarto da sua reserva: ");            
            string? numeroReservaINPUT = Console.ReadLine();
            int numeroReserva;
            int.TryParse(numeroReservaINPUT, out numeroReserva);
            
            string format = "dd/MM/yyyy HH:mm";
            Console.Write($"\nAgora digite a data do seu checkIN e do seu checkOUT\n com o formato {format}");            
            Console.Write("\ncheckIN: ");
            string? checkInINPUT = Console.ReadLine();
            DateTime checkIn;
            DateTime.TryParseExact(checkInINPUT,format, null, DateTimeStyles.None , out checkIn);

            Console.Write("\ncheckOUT: ");
            string? checkOutINPUT = Console.ReadLine();
            DateTime checkOut;
            DateTime.TryParseExact(checkOutINPUT,format, null, DateTimeStyles.None , out checkOut);

            hotel.ReservaQuarto(hotel.GetClientes()[i], numeroReserva,checkIn, checkOut);

        }
        for (int i = 0;i<hotel.GetClientes().Count;i++){
            int ultimoHistorico = hotel.GetClientes().Count-1;
            Console.WriteLine(hotel.GetClientes()[i].GetHistoricoReservas()[ultimoHistorico]);
        }


    }
}