
USE [r0781309]
GO
SET IDENTITY_INSERT [dbo].[Klant] ON 

INSERT [dbo].[Klant] ([KlantID], [Voornaam], [Achternaam], [Geboortedatum], [Nationaliteit], [Telefoonnummer], [Emailadres], [Gemeente], [Postcode], [Straat], [Huisnummer]) VALUES (1, N'Murrel', N'Venlo', 1992-03-10 , N'Surinaamse', N'+59747421724',N'murrel.venlo@hotmail.sr', N'Houttuin',N'3690', N'Niemanstraat', N'4')
INSERT [dbo].[Klant] ([KlantID], [Voornaam], [Achternaam], [Geboortedatum], [Nationaliteit], [Telefoonnummer], [Emailadres], [Gemeente], [Postcode], [Straat], [Huisnummer]) VALUES (2, N'Jurmen', N'Prijor', 1995-06-19 , N'Nederlanse', N'+3158980000', N'j.Prijor@gmail.com', N'Laakdal',N'', N'2400', N'Grote laan' N'9')
INSERT [dbo].[Klant] ([KlantID], [Voornaam], [Achternaam], [Geboortedatum], [Nationaliteit], [Telefoonnummer], [Emailadres], [Gemeente], [Postcode], [Straat], [Huisnummer]) VALUES (3, N'Fauzia', N'Ritveld', 1975-09-04 , N'Belgische', N'+325499111', N'Rit.fauz@hotmail.be', N'Kaggevinne',N'1900', N'Kerkstraat', N'16')
SET IDENTITY_INSERT [dbo].[Klant] OFF
GO
SET IDENTITY_INSERT [dbo].[Reservatie] ON 

INSERT [dbo].[Reservatie] ([ReservatieID], [KlantID], [Ophaaldatum], [Afleverdatum], [Status], [Betaalmethode]) VALUES (1, 1,  2022-05-16, 2022-05-30, N'Betaald', N'Mastercard')
INSERT [dbo].[Reservatie] ([ReservatieID], [KlantID], [Ophaaldatum], [Afleverdatum], [Status], [Betaalmethode]) VALUES (2, 2, 2022-03-10, 2022-03-17, N'Gedeeltelijk betaald', N'Amercan Express')
INSERT [dbo].[Reservatie] ([ReservatieID], [KlantID], [Ophaaldatum], [Afleverdatum], [Status], [Betaalmethode]) VALUES (3, 3, 2022-08-15, 2022-09-30, N'In behandeling', N'Bankkaart')
SET IDENTITY_INSERT [dbo].[Reservatie] OFF
GO
SET IDENTITY_INSERT [dbo].[Categorie] ON 

INSERT [dbo].[Automodel] ([CategorieID], [Beschrijving], [AantalDeuren], [AantalZitplaatsen], [PrijsPerDag]) VALUES (1, N'Gedeeltelijk vooruitbetaling. Full to full. Ophalen op de luchthaven.', 5, 7, 43.00)
INSERT [dbo].[Automodel] ([CategorieID], [Beschrijving], [AantalDeuren], [AantalZitplaatsen], [PrijsPerDag]) VALUES (2, N'Gedeeltelijk vooruitbetaling. Halfvol. Ophalen op de luchthaven.', 4, 5, 33.50)
INSERT [dbo].[Automodel] ([CategorieID], [Beschrijving], [AantalDeuren], [AantalZitplaatsen], [PrijsPerDag]) VALUES (3, N'Geen vooruitbetaling. Halfvol. Ophalen op de luchthaven.', 4, 4,  18.45)
SET IDENTITY_INSERT [dbo].[Categorie] OFF
GO
SET IDENTITY_INSERT [dbo].[ReservatieCategorie] ON 

INSERT [dbo].[ReservatieCategorie] ([ReservatieCategorieID], [ReservatieID], [CategorieID]) VALUES (1, 2, 1)
INSERT [dbo].[ReservatieCategorie] ([ReservatieCategorieID], [ReservatieID], [CategorieID]) VALUES (2, 3, 2)
INSERT [dbo].[ReservatieCategorie] ([ReservatieCategorieID], [ReservatieID], [CategorieID]) VALUES (3, 1, 3)
SET IDENTITY_INSERT [dbo].[ReservatieCategorie] OFF
GO
SET IDENTITY_INSERT [dbo].[Merk] ON 

INSERT [dbo].[Merk] ([MerkID], [MerkNaam]) VALUES (1, N'Ford Focus')
INSERT [dbo].[Merk] ([MerkID], [MerkNaam]) VALUES (2, N'Hyundai')
INSERT [dbo].[Merk] ([MerkID], [MerkNaam]) VALUES (3, N'Honda')
SET IDENTITY_INSERT [dbo].[Merk] OFF
GO
SET IDENTITY_INSERT [dbo].[Automodel] ON 

INSERT [dbo].[Automodel] ([AutomodelID], [Type], [MerkID], [Afbeelding]) VALUES (1, N'SUV', 1, N'~/images/SUV')
INSERT [dbo].[Automodel] ([AutomodelID], [Type], [MerkID], [Afbeelding]) VALUES (2, N'Sedan', 2, N'~/images/Sedan')
INSERT [dbo].[Automodel] ([AutomodelID], [Type], [MerkID], [Afbeelding]) VALUES (3, N'Hatchback', 3, N'~/images/Auto3')
SET IDENTITY_INSERT [dbo].[Automodel] OFF
GO
SET IDENTITY_INSERT [dbo].[Auto] ON 

INSERT [dbo].[Auto] ([AutoID], [AutomodelID], [CategorieID], [Nummerplaat], [Kleur]) VALUES (1, 1, 1, N'LMQN002Z', 'Rood')
INSERT [dbo].[Auto] ([AutoID], [AutomodelID], [CategorieID], [Nummerplaat], [Kleur]) VALUES (2, 2, 1, N'0067OPUS', 'Zwart')
INSERT [dbo].[Auto] ([AutoID], [AutomodelID], [CategorieID], [Nummerplaat], [Kleur]) VALUES (3, 3, 2, N'336FFKNI', 'Blauw')
SET IDENTITY_INSERT [dbo].[Auto] OFF
GO