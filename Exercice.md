# Exercice Carte

## Exercice A-1

Pour chacune des descriptions qui suivent, donnez l'instruction d'initialisation du tas qui convient :

- le tas 1 contient une carte de couleur ♣ ;
- le tas 1 contient une carte de couleur ♣ ou ♠ ;
- le tas 1 contient une carte de couleur quelconque ;
- le tas 1 contient deux cartes de couleur ♡ ;
- le tas 1 contient une carte de couleur ♡ surmontée d'un ♢ ;
- le tas 1 contient un nombre quelconque de ♠ ;
- le tas 1 contient un nombre quelconque de ♠ ou bien un nombre quelconque de ♡ ;
- le tas 1 contient un nombre quelconque de cartes de couleur ♠ ou ♡ ;
- le tas 1 contient un nombre quelconque de cartes de couleur quelconque ;
- le tas 1 contient au moins un carreau ;
- le tas 1 contient un ♣ surmonté soit d'un nombre quelconque de ♡, soit d'un nombre quelconque non nul de ♠ ;
- le tas 1 contient un nombre pair de ♡ ;
- le tas 1 contient un nombre impair de ♡ ;
- le tas 1 contient un nombre pair de ♣ ou un nombre multiple de 3 de ♠ ;
- les deux cartes extrêmes du tas 1 (la plus basse et la plus haute) sont des ♣, entre les deux il y a un nombre quelconque de successions de deux cartes de couleur ♢♡.

# Exercice Boolean

## Exercice 2-1

En utilisant les tables de vérité, prouvez quelques propriétés des opérateurs logiques et, ou et non.

## Exercice 2-2 Ou exclusif

Si a et b sont deux expressions booléennes, le `ou-exclusif` de ces deux expressions, noté a⊕b, est une nouvelle expression booléenne qui est vraie si et seulement si une seule des deux expressions a ou b est vraie. La table de vérité du `ou-exclusif` est donnée

### Table 2.6 - Table de vérité de l'opérateur ou-exclusif


a | b | a ⊕ b
--|---|-------
V | V |   F
V | F |   V
F | V |   V
F | F |   F

Écrivez l'expression a ⊕ b à l'aide des opérateurs et, ou et non.

## Exercice 2-3

__Question 1__ : Exprimez le fait que [a,b] et [c,d] sont des intervalles disjoints, attention au cas des intervalles vides, par exemple si a = 15 et b = -5.

__Question 2__ : Exprimez le fait que [a,b] et [c,d] sont des intervalles qui se recouvrent partiellement de deux manières :

- en utilisant la solution de la question précédente (c'est très simple) ;
- directement (c'est compliqué !).

## Exercice 2-4 Égalité et valeur booléenne

__Question 1__ : Soit a une expression booléenne. Réalisez la table de vérité des expressions :

- a = V
- a = F