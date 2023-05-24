
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Etudiant> etudiants = new List<Etudiant>(); // Liste pour stocker les étudiants

        // Demande les informations de l'étudiant à l'utilisateur
        Console.WriteLine("Ajout d'un nouvel étudiant :");
        Console.Write("Nom : ");
        string nom = Console.ReadLine();
        Console.Write("Prénom : ");
        string prenom = Console.ReadLine();
        Console.Write("Adresse : ");
        string adresse = Console.ReadLine();

        // Crée un nouvel objet Etudiant avec les informations fournies
        Etudiant nouvelEtudiant = new Etudiant(nom, prenom, adresse);

        // Ajoute l'étudiant à la liste des étudiants
        etudiants.Add(nouvelEtudiant);

        Console.WriteLine("Étudiant ajouté avec succès !");
        Console.ReadLine();
    }
}

class Etudiant
{
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Adresse { get; set; }

    public Etudiant(string nom, string prenom, string adresse)
    {
        Nom = nom;
        Prenom = prenom;
        Adresse = adresse;
    }
}


public class Facture
{
    public int Id { get; set; }
    public string Numero { get; set; }
    public DateTime Date { get; set; }
    public Client Client { get; set; }
    public List<Produit> Produits { get; set; }

    public void AjouterProduit(Produit produit)
    {
        Produits.Add(produit);
    }

    public void SupprimerProduit(Produit produit)
    {
        Produits.Remove(produit);
    }

    public decimal CalculerTotal()
    {
        decimal total = 0;
        foreach (var produit in Produits)
        {
            total += produit.Prix;
        }
        return total;
    }
}

public class Client
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public string Adresse { get; set; }
    public List<Facture> Factures { get; set; }

    public void AjouterFacture(Facture facture)
    {
        Factures.Add(facture);
    }

    public void SupprimerFacture(Facture facture)
    {
        Factures.Remove(facture);
    }
}

public class Produit
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public decimal Prix { get; set; }

    public void ModifierPrix(decimal nouveauPrix)
    {
        Prix = nouveauPrix;
    }
}

public class Program
{
    public static void Main()
    {
        // Création d'un client
        var client = new Client
        {
            Id = 1,
            Nom = "John Doe",
            Adresse = "123 Rue du Client"
        };

        // Création de produits
        var produit1 = new Produit
        {
            Id = 1,
            Nom = "Produit 1",
            Prix = 10
        };

        var produit2 = new Produit
        {
            Id = 2,
            Nom = "Produit 2",
            Prix = 20
        };

        // Création d'une facture
        var facture = new Facture
        {
            Id = 1,
            Numero = "F0001",
            Date = DateTime.Now,
            Client = client,
            Produits = new List<Produit>()
        };

        // Ajout des produits à la facture
        facture.AjouterProduit(produit1);
        facture.AjouterProduit(produit2);

        // Calcul du total de la facture
        decimal total = facture.CalculerTotal();

        Console.WriteLine("Total de la facture : {total}");
    }
}

