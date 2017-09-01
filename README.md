# c#_helloWorld
project Hello World in c# and .NET

## vocabulaire


+ __typage de valeur:__ en ref les variables sont definies à la volé et donc l'allocation de la mémoire ne sera pas la même
+ __délégués:__ signatures de méthode encapsulées appelées pour activer des événement de notificcations de type securité
+ __propriété:__ comme un getter pour une variable privé.
+ __expressions LINQ:__ fournit des fonctions de requête intégrées sur diverses sources de données. (pont entre le langage(objet) c# et l'acces au données) 
+ __Common Language Runtime (CLR):__   Common Language Infrastructure (CLI), une norme internationale qui sert de base pour la création d’environnements de développement et d’exécution dans lesquels les langages et bibliothèques fonctionnent ensemble en toute transparence
+ __Assembly:__ unité de déploiement indivisible - Contient la liste de l'ensemble des fichiers (exe, dll, données, images, ressources) les méta données et les autorisations requises pour que l'assembly fonctionne correctement.
+ __compilation du code:__ code source c# -> compliation langage intermediaire conforme au CLI -> stocka du LI + bitmap et chaine dans un fichier assembly (.exe || .dll) (+ manifeste contient type, vesion, culture et condition de securité).
+ __execution:__ programme C# -> Assembly + bitmap sont chargé par le CLR -> check manifste + exigence sécurité -> CLR -> comilation Just In Time JIT (LI -> instruction machine native || code managé) + gestion memoire, resource, exeption 
https://docs.google.com/presentation/d/1MReQwD0LUasC6QYdlk3CvOcH-yXpR5hJyjc7bUp-wsM/edit?usp=sharing
+ __bibliothèque de classes:__ Class library est un projet contenant des classes pouvant être utiliser par d'autre projet.
+ __solution:__ est un ensemble de projets
+ __xaml:__ langages déclaratifs utilisé pour créér des vues dans des projet .NET
+ __grid:__ balises permettant de gerer l'affichage de la fentre
+ __WPF:__ Window Presentation Foundation, solution pour crréer des fenetres dans des projet .NET
+ __Converter:__ C'est une classe qui permet de convertir des données dans la vuer sans touché au model.
+ __ObservableCollection:__ collection de données dynamiques qui notifie lorqu'il y y a de smodification de données (create, delete update)
