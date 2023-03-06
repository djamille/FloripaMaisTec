using ExcecaoEx3M1S05;

class Program
{
    static void Main(string[] args)
    {
        Evento teatro = new Evento();
        Evento show = new Evento();

        teatro.QtdIngressosVendidos = 15;
        teatro.QtdLugares = 120;

        show.QtdIngressosVendidos = 12323;
        show.QtdLugares = 12200;

        try
        {
            if (teatro.QtdLugares - teatro.QtdIngressosVendidos > 0)
            {
                Console.WriteLine("Ingresso validado! Seu lugar para o teatro está garantido.");
                teatro.ingressoVendido();
            }
            else
            {
                throw new IngressoException("Ah, que pena! Não existem mais lugares disponíveis para o teatro.");
            }
        }
        catch (IngressoException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            if (show.QtdLugares - show.QtdIngressosVendidos > 0)
            {
                Console.WriteLine("Ingresso validado! Seu lugar para o show está garantido.");
                show.ingressoVendido();
            }
            else
            {
                throw new IngressoException("Ah, que pena! Não existem mais lugares disponíveis para o show.");
            }
        }
        catch (IngressoException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}