- [Exercice Carte Basic](#exercice-carte-basic)
  - [Exercice A-1](#exercice-a-1)
  - [Exercice A-2 ★](#exercice-a-2-)
  - [Exercice A-3 ★](#exercice-a-3-)
  - [Exercice A-4 ★](#exercice-a-4-)
  - [Exercice A-5 ★](#exercice-a-5-)
- [Exercice Carte Conditionnelle](#exercice-carte-conditionnelle)
  - [Exercice A-6 ★](#exercice-a-6-)
  - [Exercice A-7 ★](#exercice-a-7-)
  - [Exercice A-8 ★](#exercice-a-8-)
  - [Exercice A-9 ★](#exercice-a-9-)
- [Exercice Carte While](#exercice-carte-while)
  - [Exercice A-10 ★](#exercice-a-10-)
  - [Exercice A-11 ★★](#exercice-a-11-)
  - [Exercice A-12 ★★](#exercice-a-12-)
  - [Exercice A-13 ★★](#exercice-a-13-)
  - [Exercice A-14 ★](#exercice-a-14-)
  - [Exercice A-15 ★★](#exercice-a-15-)
  - [Exercice A-16 ★★](#exercice-a-16-)
  - [Exercice A-17 ★★](#exercice-a-17-)
  - [Exercice A-18 ★★](#exercice-a-18-)
  - [Exercice A-19 ★★](#exercice-a-19-)
  - [Exercice A-20 ★★★](#exercice-a-20-)
  - [Exercice A-21 ★★](#exercice-a-21-)
  - [Exercice A-22 ★★★](#exercice-a-22-)
  - [Exercice A-23 ★★★](#exercice-a-23-)
- [Exercice Carte Fonctions](#exercice-carte-fonctions)
  - [Exercice A-24](#exercice-a-24)
  - [Exercice A-25 : Égalité de deux cartes](#exercice-a-25--égalité-de-deux-cartes)
  - [Exercice A-26 : Inverser l'ordre des cartes d'un Deck](#exercice-a-26--inverser-lordre-des-cartes-dun-deck)
- [Exercice Boolean](#exercice-boolean)
  - [Exercice B-1 Démonstration](#exercice-b-1-démonstration)
  - [Exercice B-2 Ou exclusif](#exercice-b-2-ou-exclusif)
  - [Exercice B-3 Intervales](#exercice-b-3-intervales)
  - [Exercice B-4 Égalité et valeur booléenne](#exercice-b-4-égalité-et-valeur-booléenne)
- [Exercice Structure de donées](#exercice-structure-de-donées)
  - [Exercice C-1](#exercice-c-1)
  - [Exercice C-2](#exercice-c-2)
  - [Exercice C-3](#exercice-c-3)
  - [Exercice C-4](#exercice-c-4)
  - [Exercice C-5](#exercice-c-5)
- [Classe et Objet](#classe-et-objet)

# Exercice Carte Basic

## Exercice A-1

Pour chacune des descriptions qui suivent, donnez l'instruction d'initialisation du Deck qui convient :

- le Deck 1 contient une carte de couleur ♣ ;
- le Deck 1 contient une carte de couleur ♣ ou ♠ ;
- le Deck 1 contient une carte de couleur quelconque ;
- le Deck 1 contient deux cartes de couleur ♡ ;
- le Deck 1 contient une carte de couleur ♡ surmontée d'un ♢ ;
- le Deck 1 contient un nombre quelconque de ♠ ;
- le Deck 1 contient un nombre quelconque de ♠ ou bien un nombre quelconque de ♡ ;
- le Deck 1 contient un nombre quelconque de cartes de couleur ♠ ou ♡ ;
- le Deck 1 contient un nombre quelconque de cartes de couleur quelconque ;
- le Deck 1 contient au moins un carreau ;
- le Deck 1 contient un ♣ surmonté soit d'un nombre quelconque de ♡, soit d'un nombre quelconque non nul de ♠ ;
- le Deck 1 contient un nombre pair de ♡ ;
- le Deck 1 contient un nombre impair de ♡ ;
- le Deck 1 contient un nombre pair de ♣ ou un nombre multiple de 3 de ♠ ;
- les deux cartes extrêmes du Deck 1 (la plus basse et la plus haute) sont des ♣, entre les deux il y a un nombre quelconque de successions de deux cartes de couleur ♢♡.

## Exercice A-2 ★

__Situation initiale :__

- Deck 1 : `"TT"`
- Deck 2 : `""`
- Deck 3 : `""`
- Deck 4 : `""`

__Situation finale :__

- Deck 1 : `""`
- Deck 2 : `"TT"`
- Deck 3 : `""`
- Deck 4 : `""`

## Exercice A-3 ★

__Situation initiale :__

- Deck 1 : `"TK"`
- Deck 2 : `""`
- Deck 3 : `""`
- Deck 4 : `""`

__Situation finale :__

- Deck 1 : `"KT"`
- Deck 2 : `""`
- Deck 3 : `""`
- Deck 4 : `""`

## Exercice A-4 ★

__Situation initiale :__

- Deck 1 : `"TKTK"`
- Deck 2 : `""`
- Deck 3 : `""`
- Deck 4 : `""`

__Situation finale :__

- Deck 1 : `"KKTT"`
- Deck 2 : `""`
- Deck 3 : `""`
- Deck 4 : `""`

## Exercice A-5 ★

__Situation initiale :__

- Deck 1 : `"TKCP"`
- Deck 2 : `""`
- Deck 3 : `""`
- Deck 4 : `""`

__Situation finale :__

- Deck 1 : `"PCKT"`
- Deck 2 : `""`
- Deck 3 : `""`
- Deck 4 : `""`

# Exercice Carte Conditionnelle

## Exercice A-6 ★

__Situation initiale :__

- Deck 1 : `"T+P"`
- Deck 2 : `""`
- Deck 3 : `""`
- Deck 4 : `""`

__Situation finale :__

- Deck 1 : `""`
- Deck 2 : `"[T]"`
- Deck 3 : `"[P]"`
- Deck 4 : `""`

## Exercice A-7 ★

__Situation initiale :__

- Deck 1 : `"(T+K+C+P)(T+K+C+P)"`
- Deck 2 : `""`
- Deck 3 : `""`
- Deck 4 : `""`

__Situation finale :__

- Deck 1 : `""`
- Deck 2 : `""`
- Deck 3 : `"(T+K+C+P)(T+K+C+P)"↑`
- Deck 4 : `""`

Le symbole ↑ signifiant que les cartes sont dans l'ordre croissant (i.e. la carte du dessous a une valeur inférieure ou égale à celle du dessus).

## Exercice A-8 ★

__Situation initiale :__

- Deck 1 : `"T+K+C+P"`
- Deck 2 : `""`
- Deck 3 : `""`
- Deck 4 : `""`

__Situation finale :__

- Deck 1 : `"[T]"`
- Deck 2 : `"[K]"`
- Deck 3 : `"[C]"`
- Deck 4 : `"[P]"`

## Exercice A-9 ★

__Situation initiale :__

- Deck 1 : `"(T+K+C+P)(T+K+C+P)"`
- Deck 2 : `""`
- Deck 3 : `""`
- Deck 4 : `""`

__Situation finale :__

- Deck 1 : `"[K+C]"`
- Deck 2 : `"[T+P]"`
- Deck 3 : `""`
- Deck 4 : `""`

# Exercice Carte While

## Exercice A-10 ★

__Situation initiale :__

- Deck 1 : `"[T]"`
- Deck 2 : `""`
- Deck 3 : `""`
- Deck 4 : `""`

__Situation finale :__

- Deck 1 : `""`
- Deck 2 : `"[T]"`
- Deck 3 : `""`
- Deck 4 : `""`

## Exercice A-11 ★★

__Situation initiale :__

- Deck 1 : `"[K+C][T+P]"`
- Deck 2 : `""`
- Deck 3 : `""`
- Deck 4 : `""`

__Situation finale :__

- Deck 1 : `"[T+P][K+C]"`
- Deck 2 : `""`
- Deck 3 : `""`
- Deck 4 : `""`

## Exercice A-12 ★★

__Situation initiale :__

- Deck 1 : `"[K]"`
- Deck 2 : `"[T]"`
- Deck 3 : `""`
- Deck 4 : `""`

__Situation finale :__

- Deck 1 : `"[K]"`
- Deck 2 : `""`
- Deck 3 : `"[KT]"`
- Deck 4 : `""`

ou bien :

- Deck 1 : `""`
- Deck 2 : `"[T]"`
- Deck 3 : `"[KT]"`
- Deck 4 : `""`

## Exercice A-13 ★★

__Situation initiale :__

- Deck 1 : `"[T]"`
- Deck 2 : `""`
- Deck 3 : `""`
- Deck 4 : `""`

__Situation finale :__

- Deck 1 : `""`
- Deck 2 : `"[T]"`
- Deck 3 : `"[T]"`
- Deck 4 : `""`

Le nombre de cartes des Deck 2 et 3 différant d'au plus 1 dans la situation finale.

## Exercice A-14 ★

__Situation initiale :__

- Deck 1 : `"[T]"`
- Deck 2 : `"[K]"`
- Deck 3 : `"[P]"`
- Deck 4 : `""`

__Situation finale :__

- Deck 1 : `""`
- Deck 2 : `"[T]"`
- Deck 3 : `"[K]"`
- Deck 4 : `"[P]"`

En faire deux versions, la seconde utilisant une procédure vider_Deck(depart,arrivee) qui vide le Deck depart sur le Deck arrivee.

## Exercice A-15 ★★

__Situation initiale :__

- Deck 1 : `"[T]"`
- Deck 2 : `"[K]"`
- Deck 3 : `"[C]"`
- Deck 4 : `"[P]"`

__Situation finale :__

- Deck 1 : `"[P]"`
- Deck 2 : `"[T]"`
- Deck 3 : `"[K]"`
- Deck 4 : `"[C]"`

## Exercice A-16 ★★

__Situation initiale :__

- Deck 1 : `"[T][K][C][P]"`
- Deck 2 : `""`
- Deck 3 : `""`
- Deck 4 : `""`

__Situation finale :__

- Deck 1 : `"[P][C][K][T]"`
- Deck 2 : `""`
- Deck 3 : `""`
- Deck 4 : `""`

## Exercice A-17 ★★

__Situation initiale :__

- Deck 1 : `"[T]"`
- Deck 2 : `"[K]"`
- Deck 3 : `"[P]"`
- Deck 4 : `""`

__Situation finale :__

- Deck 1 : `""`
- Deck 2 : `""`
- Deck 3 : `""`
- Deck 4 : `"[TKP][XY][Z]"`

Où X et Y désignent les deux couleurs restantes lorsque l'une des couleurs manque, et Z désigne la couleur restante lorsque X ou Y manque.

## Exercice A-18 ★★

__Situation initiale :__

- Deck 1 : `"[T+K+C+P]"`
- Deck 2 : `""`
- Deck 3 : `""`
- Deck 4 : `""`

__Situation finale :__

- Deck 1 : `"[T]"`
- Deck 2 : `"[K]"`
- Deck 3 : `"[C]"`
- Deck 4 : `"[P]"`

## Exercice A-19 ★★

__Situation initiale :__

- Deck 1 : `"T[T]"`
- Deck 2 : `""`
- Deck 3 : `""`
- Deck 4 : `""`

__Situation finale :__

- Deck 1 : `""`
- Deck 2 : `"T"−
- Deck 3 : `"[T]"`
- Deck 4 : `""`

Le symbole − indique que la carte est de valeur minimale.

## Exercice A-20 ★★★

__Situation initiale :__

- Deck 1 : `"[T]"`
- Deck 2 : `""`
- Deck 3 : `""`
- Deck 4 : `""`

__Situation finale :__

- Deck 1 : `""`
- Deck 2 : `"[T]↑
- Deck 3 : `""`
- Deck 4 : `""`

Le symbole ↑ signifiant que les cartes sont rangées par ordre croissant de valeurs de bas en haut.

## Exercice A-21 ★★

__Situation initiale :__

- Deck 1 : `"[T+K]"`
- Deck 2 : `""`
- Deck 3 : `""`
- Deck 4 : `""`

__Situation finale :__

- Deck 1 : `"[X][Y]"`
- Deck 2 : `""`
- Deck 3 : `""`
- Deck 4 : `""`

Le symbole X désigne la couleur (♣ ou ♢) la plus nombreuse, l'autre couleur étant désignée par Y.

## Exercice A-22 ★★★

__Situation initiale :__

- Deck 1 : `"K[T]"`
- Deck 2 : `""`
- Deck 3 : `""`
- Deck 4 : `""`

__Situation finale :__

- Deck 1 : `"[T+K]"`
- Deck 2 : `"[T+K]"`
- Deck 3 : `"[T+K]"`
- Deck 4 : `"[T+K]"`

Les trèfles étant équitablement répartis sur les quatre Deck, l'unique carreau se trouvant n'importe où.

Remarque : ce problème est infaisable sans le carreau.

## Exercice A-23 ★★★

__Situation initiale :__

- Deck 1 : `"[T]"`
- Deck 2 : `"[K]"`
- Deck 3 : `"[C]"`
- Deck 4 : `"[P]"`

__Situation finale :__

- Deck 1 : `"[T] ↑"`
- Deck 2 : `"[K] ↑"`
- Deck 3 : `"[C] ↑"`
- Deck 4 : `"[P] ↑"`

Le symbole ↑ signifiant que les cartes sont rangées par ordre croissant de valeurs de bas en haut.


# Exercice Carte Fonctions

## Exercice A-24

Soit la fonction définie par

```
public bool meme_couleur(CardColor color, Deck deck)
{
    return gm.topCardColor(deck) == color;
}
```

__Question 1__ : Quel problème pose cette fonction si lors d'un appel le Deck passé en paramètre est vide ?

__Question 2__ : Comment modifier la fonction meme_couleur pour qu'elle renvoie la valeur faux si le Deck Deck est vide.

## Exercice A-25 : Égalité de deux cartes

__Question 1__ : Écrivez une fonction qui teste l'égalité de la valeur de deux cartes situées au sommet de deux Deck que l'on supposera non vide.

__Question 2__ : Puis écrivez une fonction qui teste l'égalité de deux cartes (valeur et couleur) situées au sommet de deux Deck supposés non vides.

## Exercice A-26 : Inverser l'ordre des cartes d'un Deck

Il s'agit d'écrire une fonction _inverserDeck_ pour inverser l'ordre des cartes du Deck 1. Par exemple, si on a - Deck 1 : `"TCCPK"` alors après exécution de l'instruction `inverserDeck()`, on doit avoir - Deck 1 : `"KPCCT"`.

__Question 1__ : Faites-le avec l'hypothèse que les autres Deck sont vides.

__Question 2__ : Réaliser la procédure sans supposer que les autres Deck sont vides.


# Exercice Boolean

## Exercice B-1 Démonstration

En utilisant les tables de vérité, prouvez quelques propriétés des opérateurs logiques et, ou et non.

## Exercice B-2 Ou exclusif

Si a et b sont deux expressions booléennes, le `ou-exclusif` de ces deux expressions, noté a⊕b, est une nouvelle expression booléenne qui est vraie si et seulement si une seule des deux expressions a ou b est vraie. La table de vérité du `ou-exclusif` est donnée

__Table 2.6 - Table de vérité de l'opérateur ou-exclusif__


a | b | a ⊕ b
--|---|-------
V | V |   F
V | F |   V
F | V |   V
F | F |   F

Écrivez l'expression a ⊕ b à l'aide des opérateurs et, ou et non.

## Exercice B-3 Intervales

__Question 1__ : Exprimez le fait que [a,b] et [c,d] sont des intervalles disjoints, attention au cas des intervalles vides, par exemple si a = 15 et b = -5.

__Question 2__ : Exprimez le fait que [a,b] et [c,d] sont des intervalles qui se recouvrent partiellement de deux manières :

- en utilisant la solution de la question précédente (c'est très simple) ;
- directement (c'est compliqué !).

## Exercice B-4 Égalité et valeur booléenne

__Question 1__ : Soit a une expression booléenne. Réalisez la table de vérité des expressions :

- a = V
- a = F

# Exercice Structure de donées

## Exercice C-1 

Grâce à l'intruction ci-dessous: 

 ```Random.Range(a,b);``` (https://docs.unity3d.com/ScriptReference/Random.Range.html)

Ecrire une fonction qui prend trois entiers `a`, `b` et `n` et qui renvoie un tableau d'entiers de dimension `n` initialisés aléatoirement entre `a` et `b`.

## Exercice C-2

Ecrire une fonction qui affiche succéssivement les valeurs d'un tableau d'entier

## Exercice C-3

Ecrire une fonction qui cacule et affiche le nombre d'entiers pair d'un tableau.
Faire la même chose pour les entiers impair.

## Exercice C-4

Ecrire une fonction qui cacule et affiche la moyenne des entiers contenu dans un tableau.

## Exercice C-5

Utiliser la fonction de l'exercice 1 pour générer un tableaux de la taille du nombre d'élèves initialisé entre 0 et 20.

Ecrire und fonction qui affiche
- Qui renvoie un tableaux des notes trié par ordre croissant. 
- Qui affihce la Moyennes des Notes.
- Qui affihce la plus grande note obtenu
- Qui affihce la plus petite note obtenu
- Qui affihce la médiane des notes

__Pour calculer la médiane__ : On classe les valeurs de la série statistique dans l'ordre croissant : Si le nombre de valeurs est impair, la médiane est la valeur du milieu. S'il est pair, la médiane est la demi-somme des deux valeurs du milieu.


# Classe et Objet

Ecrire une class ```Vector2D```
Un Vecteur est un objet ayant une coordonée x et une coordonée y

- Ecrire le contructeur qui prend en paramètre les coordonées du point
- Ecrire des ```setter``` et des ```getter``` pour les coordonées du Vecteur
- Ecrire une fonction ```Add``` qui prend un autre Vecteur en paramètre et qui ajoute au Vecteur actuelle l'autre Vecteur.
- Ecrire une fonction ```magnitude``` qui renvoie la norme du vecteur: 
  
  ```norme = √(x² + y²) ```



