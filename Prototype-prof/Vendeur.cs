class Vendeur {
    static protected Vendeur instance;

    private List<string> havCancerClients = new List<string>();

    private Vendeur(List<string> havCancerClients ) {
        this.havCancerClients = havCancerClients;
    }

    public static Vendeur Instance(List<string> havCancerClients ) {
        return instance != null ? instance : instance = new Vendeur(havCancerClients);
    }

    public void sellTobaccoTo(string cli) {
        if (havCancerClients.Contains(cli))
            throw new Exception(cli + " hav cancer and can't buy tobacco");

        System.Console.WriteLine("vendeur selled tobacco to " + cli);
    }
}
