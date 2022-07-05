class Vendeur {
    static protected Vendeur instance;

    private Vendeur() {}

    Vendeur Instance() {
        return instance != null ? instance : instance = new Vendeur();
    }
}
