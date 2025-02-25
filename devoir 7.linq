<Query Kind="Statements" />


Étudiant etu = new();
Réinitialiser(etu, "Johanne", new(2000, 12, 12),
	new[] { "League of legends", "Diablo" }, true);
etu.Dump("Lili-Rose B."); 
Réinitialiser(etu, "Jeanny", new(2002, 4, 4),
	new[] { "Roblox", "Minecraft" }, false);
etu.Dump();

static void Réinitialiser(Étudiant etu, string nom, 
	DateOnly dateNaissance, string[] jeuxFavoris, bool estFumeur)
{
	etu.Nom = nom;
	etu.DateNaissance = dateNaissance;
	etu.JeuxFavoris.Clear();
	etu.JeuxFavoris.AddRange(jeuxFavoris);	
	etu.EstFumeur = estFumeur;
}


class Étudiant
{
	public string? Nom;
	public DateOnly DateNaissance;
	public bool EstFumeur;
	public readonly List<string> JeuxFavoris = new();
}