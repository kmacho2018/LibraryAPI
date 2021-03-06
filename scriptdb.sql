USE [master]
GO
/****** Object:  Database [LibraryDb]    Script Date: 7/4/2018 3:48:04 PM ******/
CREATE DATABASE [LibraryDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LibraryDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\LibraryDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LibraryDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\LibraryDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [LibraryDb] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LibraryDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LibraryDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LibraryDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LibraryDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LibraryDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LibraryDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [LibraryDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LibraryDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LibraryDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LibraryDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LibraryDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LibraryDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LibraryDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LibraryDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LibraryDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LibraryDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LibraryDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LibraryDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LibraryDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LibraryDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LibraryDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LibraryDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LibraryDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LibraryDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LibraryDb] SET  MULTI_USER 
GO
ALTER DATABASE [LibraryDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LibraryDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LibraryDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LibraryDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LibraryDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LibraryDb] SET QUERY_STORE = OFF
GO
USE [LibraryDb]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [LibraryDb]
GO
/****** Object:  Table [dbo].[BookState]    Script Date: 7/4/2018 3:48:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookState](
	[BookStateId] [int] IDENTITY(1,1) NOT NULL,
	[StateName] [varchar](100) NULL,
	[StateDescription] [varchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[BookStateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Autor]    Script Date: 7/4/2018 3:48:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autor](
	[AutorId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[AutorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 7/4/2018 3:48:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[BookId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[BookStateId] [int] NULL,
	[AutorId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_books]    Script Date: 7/4/2018 3:48:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[vw_books]asSELECT        a.BookId, a.Name, b.StateName AS BookState, c.Name AS Autor,c.AutorId,b.BookStateId,b.StateDescription
FROM            dbo.Book AS a INNER JOIN
                         dbo.BookState AS b ON b.BookStateId = a.BookStateId INNER JOIN
                         dbo.Autor AS c ON c.AutorId = a.AutorId
GO
/****** Object:  Table [dbo].[BookPage]    Script Date: 7/4/2018 3:48:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookPage](
	[BookPageId] [int] IDENTITY(1,1) NOT NULL,
	[BookId] [int] NULL,
	[PageNumber] [int] NULL,
	[Content] [varchar](max) NULL,
 CONSTRAINT [PK__BookPage__2CA39CCE559131A6] PRIMARY KEY CLUSTERED 
(
	[BookPageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Autor] ON 
GO
INSERT [dbo].[Autor] ([AutorId], [Name]) VALUES (1, N' Richard Bach')
GO
INSERT [dbo].[Autor] ([AutorId], [Name]) VALUES (2, N'Scott Haselman')
GO
SET IDENTITY_INSERT [dbo].[Autor] OFF
GO
SET IDENTITY_INSERT [dbo].[Book] ON 
GO
INSERT [dbo].[Book] ([BookId], [Name], [BookStateId], [AutorId]) VALUES (1, N'Juan Salvador Gaviota', 1, 1)
GO
INSERT [dbo].[Book] ([BookId], [Name], [BookStateId], [AutorId]) VALUES (2, N'Pro C#', 2, 2)
GO
SET IDENTITY_INSERT [dbo].[Book] OFF
GO
SET IDENTITY_INSERT [dbo].[BookPage] ON 
GO
INSERT [dbo].[BookPage] ([BookPageId], [BookId], [PageNumber], [Content]) VALUES (1, 1, 1, N'Juan Salvador Gaviota Amanecía, y el nuevo sol pintaba de oro las ondas de un
mar tranquilo.
 Chapoteaba un pesquero a un kilometro de la costa cuando, de pronto, rasgó
el aire la voz llamando a la Bandada de la Comida y una multitud de mil gaviotas se
aglomeró para regatear y luchar por cada pizca de comida.
 Comenzaba otro día de ajetreos.
 Pero alejado y solitario, más allá de barcas y playas, está practicando Juan
Salvador Gaviota.
 A treinta metros de altura, bajó sus pies palmeados, alzó su pico, y se esforzó
por mantener en sus alas esa dolorosa y difícil posición requerida para lograr un
vuelo pausado.
 Aminoró su velocidad hasta que el viento no fue mas que un susurro en su
cara, hasta que el océano pareció detenerse allá abajo.
 Entornó los ojos en feroz concentración, contuvo el aliento, forzó aquella
torsión un... sólo... centímetro... más... Encrespáronse sus plumas, se atascó y
cayó.
 Las gaviotas, como es bien sabido, nunca se atascan, nunca se detienen.
 Detenerse en medio del vuelo es para ellas vergüenza, y es deshonor.
 Pero Juan Salvador Gaviota, sin avergonzarse, y al extender otra vez sus alas
en aquella temblorosa y ardua torsión - parando, parando, y atascándose de
nuevo-, no era un pájaro cualquiera.
 La mayoría de las gaviotas no se molesta en aprender sino las normas de
vuelo más elementales: como ir y volver entre playa y comida.
 Para la mayoría de las gaviotas, no es volar lo que importa, sino comer.
 Para esta gaviota, sin embargo, no era comer lo que le importaba, sino volar. ')
GO
INSERT [dbo].[BookPage] ([BookPageId], [BookId], [PageNumber], [Content]) VALUES (2, 1, 2, N' Más que nada en el mundo, Juan Salvador Gaviota amaba volar.
 Este modo de pensar, descubrió, no es la manera con que uno se hace popular
entre los demás pájaros.
 Hasta sus padres se desilusionaron al ver a Juan pasarse días enteros, solo,
haciendo cientos de planeos a baja altura, experimentando.
 No comprendía por qué, por ejemplo, cuando volaba sobre el agua a alturas
inferiores a la mitad de la envergadura de sus alas, podía quedarse en el aire más
tiempo, con menos esfuerzo; y sus planeos no terminaban con el normal chapuzón
al tocar sus patas en el mar, sino que dejaba tras de sí una estela plana y larga al
rozar la superficie con sus patas plegadas en aerodinámico gesto contra su cuerpo.
 Pero fue al empezar sus aterrizajes de patas recogidas -que luego revisaba
pas
Bandada, Juan? ¿Por qué
no d
do saber qué puedo hacer en el aire y qué no.
saberlo.
adre, con cierta ternura-.
y los peces de superficie se habrán ido a las
prof
studiar, estudia sobre la comida y cómo conseguirla.
¿sabes? No
olvid
entó comportarse como las demás gaviotas; lo
inte
o a paso sobre la playa- que sus padres se desanimaron aún más.
 -¿Por qué, Juan, por qué? -preguntaba su madre-.
 ¿Por qué te resulta tan difícil ser como el resto de la
ejas los vuelos rasantes a los pelícanos y a los albatros? ¿Por qué no comes?
¡Hijo, ya no eres más que hueso y plumas! -No me importa ser hueso y plumas,
mamá.
 Sólo preten
 Nada más.
 Sólo deseo
 -Mira, Juan -dijo su p
 El invierno está cerca.
 Habrá pocos barcos,
undidades.
 Si quieres e
 Esto de volar es muy bonito, pero no puedes comerte un planeo,
es que la razón de volar es comer.
 Juan asintió obedientemente.
 Durante los días sucesivos, int
ntó de verdad, trinando y batiéndose con la Bandada cerca del muelle y los
pesqueros, lanzándose sobre un pedazo de pan y algún pez. ')
GO
INSERT [dbo].[BookPage] ([BookPageId], [BookId], [PageNumber], [Content]) VALUES (3, 1, 3, N' Pero no le dió resultado.
 Es todo inútil, pensó, y deliberadamente dejó caer una anchoa duramente
disp
olar.
Juan Salvador
Gav
 más
ace
das sus fuerzas, se metió
en u
metros por hora, velocidad a la cual el ala
leva
 lo mismo.
 al máximo de su habilidad, perdía el
con
metros.
s hacia arriba, luego inclinándose, hasta lograr un
pica
a vez que trataba de mantener alzada al máximo su ala
izqu
 cien kilómetros por
hora
papado, pensó al fin que la clave debia ser mantener las alas quietas a alta
velo
a abajo y las alas completamente extendidas y estables desde el momento
en q
utada a una vieja y hambrienta gaviota que le perseguía.
 Podría estar empleando todo este tiempo en aprender a v
 ¡Hay tanto que aprender! No pasó mucho tiempo sin que
iota saliera solo de nuevo hacia alta mar, hambriento, feliz, aprendiendo.
 El tema fue la velocidad, y en una semana de prácticas había aprendido
rca de la velocidad que la más veloz de las gaviotas.
 A una altura de trescientos metros, aleteando con to
n abrupto y flameante picado hacia las olas, y aprendió por qué las gaviotas no
hacen abruptos y flameantes picados.
 En sólo seis segundos volo a cien kiló
ntada empieza a ceder.
 Una vez tras otra le sucedió
 A pesar de todo su cuidado, trabajando
trol a alta velocidad.
 Subía a trescientos
 Primero con todas sus fuerza
do vertical.
 Entonces, cad
ierda, giraba violentamente hacia ese lado, y al tratar de levantar su derecha
para equilibrarse, entraba, como un rayo, en una descontrolada barrena.
 Tenía que ser mucho más cuidadoso al levantar esa ala.
 Diez veces lo intentó, y las diez veces, al pasar a más de
, terminó en un montón de plumas descontroladas, estrellándose contra el
agua.
 Em
cidad; aletear, se dijo, hasta setenta por hora, y entonces dejar las alas quietas.
 Lo intentó otra vez a setecientos metros de altura, descendiendo en vertical, el
pico haci
ue pasó los setenta kilómetros por hora. ')
GO
SET IDENTITY_INSERT [dbo].[BookPage] OFF
GO
SET IDENTITY_INSERT [dbo].[BookState] ON 
GO
INSERT [dbo].[BookState] ([BookStateId], [StateName], [StateDescription]) VALUES (1, N'Available', N'Book Available')
GO
INSERT [dbo].[BookState] ([BookStateId], [StateName], [StateDescription]) VALUES (2, N'Discontinued', N'Book Discontinued')
GO
INSERT [dbo].[BookState] ([BookStateId], [StateName], [StateDescription]) VALUES (3, N'Unavailable', N'Book Unavailable')
GO
SET IDENTITY_INSERT [dbo].[BookState] OFF
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD FOREIGN KEY([AutorId])
REFERENCES [dbo].[Autor] ([AutorId])
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD FOREIGN KEY([BookStateId])
REFERENCES [dbo].[BookState] ([BookStateId])
GO
ALTER TABLE [dbo].[BookPage]  WITH CHECK ADD  CONSTRAINT [FK__BookPage__BookId__2D27B809] FOREIGN KEY([BookId])
REFERENCES [dbo].[Book] ([BookId])
GO
ALTER TABLE [dbo].[BookPage] CHECK CONSTRAINT [FK__BookPage__BookId__2D27B809]
GO
USE [master]
GO
ALTER DATABASE [LibraryDb] SET  READ_WRITE 
GO
