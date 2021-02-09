using Bildirim.Domain.Entity.Entities.Authorization;
using Bildirim.Domain.Entity.Entities.Shared;
using Bildirim.Domain.Entity.Entities.Types;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Bildirim.App.Migrations
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region Types

            modelBuilder.Entity<RoleType>().HasData(
                new RoleType { Id = 1, Adi = "Yönetici", CreatedDateTime = DateTime.Today, CreatedUserId = 1, UpdatedDateTime = null, UpdatedUserId = null },
                new RoleType { Id = 2, Adi = "Üye", CreatedDateTime = DateTime.Today, CreatedUserId = 1, UpdatedDateTime = null, UpdatedUserId = null }
            );

            modelBuilder.Entity<UserStatusType>().HasData(
                new UserStatusType { Id = 1, Adi = "Aktif", CreatedDateTime = DateTime.Today, CreatedUserId = 1, UpdatedDateTime = null, UpdatedUserId = null },
                new UserStatusType { Id = 2, Adi = "Silinmiş", CreatedDateTime = DateTime.Today, CreatedUserId = 1, UpdatedDateTime = null, UpdatedUserId = null },
                new UserStatusType { Id = 3, Adi = "Kara Listede", CreatedDateTime = DateTime.Today, CreatedUserId = 1, UpdatedDateTime = null, UpdatedUserId = null },
                new UserStatusType { Id = 4, Adi = "Aktivasyon Bekliyor", CreatedDateTime = DateTime.Today, CreatedUserId = 1, UpdatedDateTime = null, UpdatedUserId = null }
            );

            modelBuilder.Entity<UserLoginType>().HasData(
               new UserLoginType { Id = 1, Adi = "Normal", CreatedDateTime = DateTime.Today, CreatedUserId = 1, UpdatedDateTime = null, UpdatedUserId = null },
               new UserLoginType { Id = 2, Adi = "Google", CreatedDateTime = DateTime.Today, CreatedUserId = 1, UpdatedDateTime = null, UpdatedUserId = null },
               new UserLoginType { Id = 3, Adi = "Facebook", CreatedDateTime = DateTime.Today, CreatedUserId = 1, UpdatedDateTime = null, UpdatedUserId = null }
           );

            modelBuilder.Entity<NotificationStatusType>().HasData(
                new NotificationStatusType { Id = 1, Adi = "Silinmiş", CreatedDateTime = DateTime.Today, CreatedUserId = 1, UpdatedDateTime = null, UpdatedUserId = null },
                new NotificationStatusType { Id = 2, Adi = "Onay Bekliyor", CreatedDateTime = DateTime.Today, CreatedUserId = 1, UpdatedDateTime = null, UpdatedUserId = null },
                new NotificationStatusType { Id = 3, Adi = "Onaylandı", CreatedDateTime = DateTime.Today, CreatedUserId = 1, UpdatedDateTime = null, UpdatedUserId = null }
            );

            modelBuilder.Entity<NotificationType>().HasData(
                new NotificationType { Id = 1, Adi = "Kampanya", ParentId = 0, CreatedDateTime = DateTime.Today, CreatedUserId = 1, UpdatedDateTime = null, UpdatedUserId = null },
                new NotificationType { Id = 2, Adi = "Bireysel", ParentId = 1, CreatedDateTime = DateTime.Today, CreatedUserId = 1, UpdatedDateTime = null, UpdatedUserId = null },
                new NotificationType { Id = 3, Adi = "Ticari", ParentId = 1, CreatedDateTime = DateTime.Today, CreatedUserId = 1, UpdatedDateTime = null, UpdatedUserId = null }
            );

            #endregion

            #region İl

            modelBuilder.Entity<NotificationType>().HasData(
                new City
                {
                    Id = 1,
                    Adi = "Adana",
                    Kod = 1
                },
                new City
                {
                    Id = 2,
                    Adi = "Adıyaman",
                    Kod = 2
                },
                new City
                {
                    Id = 3,
                    Adi = "Afyon",
                    Kod = 3
                },
                new City
                {
                    Id = 4,
                    Adi = "Ağrı",
                    Kod = 4
                },
                new City
                {
                    Id = 68,
                    Adi = "Aksaray",
                    Kod = 68
                },
                new City
                {
                    Id = 5,
                    Adi = "Amasya",
                    Kod = 5
                },
                new City
                {
                    Id = 6,
                    Adi = "Ankara",
                    Kod = 6
                },
                new City
                {
                    Id = 7,
                    Adi = "Antalya",
                    Kod = 7
                },
                new City
                {
                    Id = 75,
                    Kod = 75,
                    Adi = "Ardahan"
                },
                new City
                {
                    Id = 8,
                    Kod = 8,
                    Adi = "Artvin"
                },
                new City
                {
                    Adi = "Aydın",
                    Id = 9,
                    Kod = 9
                },
                new City
                {
                    Adi = "Balıkesir",
                    Id = 10,
                    Kod = 10
                },
                new City
                {
                    Id = 74,
                    Kod = 74,
                    Adi = "Bartın"
                },
                new City
                {
                    Id = 72,
                    Kod = 72,
                    Adi = "Batman"
                },
                new City
                {
                    Id = 69,
                    Kod = 69,
                    Adi = "Bayburt"
                },
                new City
                {
                    Id = 11,
                    Kod = 11,
                    Adi = "Bilecik"
                },
                new City
                {
                    Id = 12,
                    Kod = 12,
                    Adi = "Bingöl"
                },
                new City
                {
                    Id = 13,
                    Kod = 13,
                    Adi = "Bitlis"
                },
                new City
                {
                    Id = 14,
                    Kod = 14,
                    Adi = "Bolu"
                },
                new City
                {
                    Id = 15,
                    Kod = 15,
                    Adi = "Burdur"
                },
                new City
                {
                    Id = 16,
                    Kod = 16,
                    Adi = "Bursa"
                },
                new City
                {
                    Id = 17,
                    Kod = 17,
                    Adi = "Çanakkale"
                },
                new City
                {
                    Id = 18,
                    Kod = 18,
                    Adi = "Çankırı"
                },
                new City
                {
                    Id = 19,
                    Kod = 19,
                    Adi = "Çorum"
                },
                new City
                {
                    Id = 20,
                    Kod = 20,
                    Adi = "Denizli"
                },
                new City
                {
                    Id = 21,
                    Kod = 21,
                    Adi = "Diyarbakır"
                },
                new City
                {
                    Id = 81,
                    Kod = 81,
                    Adi = "Düzce"
                },
                new City
                {
                    Id = 22,
                    Kod = 22,
                    Adi = "Edirne"
                },
                new City
                {
                    Id = 23,
                    Kod = 23,
                    Adi = "Elazığ"
                },
                new City
                {
                    Id = 24,
                    Kod = 24,
                    Adi = "Erzincan"
                },
                new City
                {
                    Id = 25,
                    Kod = 25,
                    Adi = "Erzurum"
                },
                new City
                {
                    Id = 26,
                    Kod = 26,
                    Adi = "Eskişehir"
                },
                new City
                {
                    Id = 27,
                    Kod = 27,
                    Adi = "Gaziantep"
                },
                new City
                {
                    Id = 28,
                    Kod = 28,
                    Adi = "Giresun"
                },
                new City
                {
                    Id = 29,
                    Kod = 29,
                    Adi = "Gümüşhane"
                },
                new City
                {
                    Id = 30,
                    Kod = 30,
                    Adi = "Hakkari"
                },
                new City
                {
                    Id = 31,
                    Kod = 31,
                    Adi = "Hatay"
                },
                new City
                {
                    Id = 76,
                    Kod = 76,
                    Adi = "Iğdır"
                },
                new City
                {
                    Id = 32,
                    Kod = 32,
                    Adi = "Isparta"
                },
                new City
                {
                    Id = 34,
                    Kod = 34,
                    Adi = "İstanbul"
                },
                new City
                {
                    Id = 35,
                    Kod = 35,
                    Adi = "İzmir"
                },
                new City
                {
                    Id = 46,
                    Kod = 46,
                    Adi = "Kahramanmaraş"
                },
                new City
                {
                    Id = 78,
                    Kod = 78,
                    Adi = "Karabük"
                },
                new City
                {
                    Id = 70,
                    Kod = 70,
                    Adi = "Karaman"
                },
                new City
                {
                    Id = 36,
                    Kod = 36,
                    Adi = "Kars"
                },
                new City
                {
                    Id = 37,
                    Kod = 37,
                    Adi = "Kastamonu"
                },
                new City
                {
                    Id = 38,
                    Kod = 38,
                    Adi = "Kayseri"
                },
                new City
                {
                    Id = 79,
                    Kod = 79,
                    Adi = "Kilis"
                },
                new City
                {
                    Id = 71,
                    Kod = 71,
                    Adi = "Kırıkkale"
                },
                new City
                {
                    Id = 39,
                    Kod = 39,
                    Adi = "Kırklareli"
                },
                new City
                {
                    Id = 40,
                    Kod = 40,
                    Adi = "Kırşehir"
                },
                new City
                {
                    Id = 41,
                    Kod = 41,
                    Adi = "Kocaeli"
                },
                new City
                {
                    Id = 42,
                    Kod = 42,
                    Adi = "Konya"
                },
                new City
                {
                    Id = 43,
                    Kod = 43,
                    Adi = "Kütahya"
                },
                new City
                {
                    Id = 44,
                    Kod = 44,
                    Adi = "Malatya"
                },
                new City
                {
                    Id = 45,
                    Kod = 45,
                    Adi = "Manisa"
                },
                new City
                {
                    Id = 47,
                    Kod = 47,
                    Adi = "Mardin"
                },
                new City
                {
                    Id = 33,
                    Kod = 33,
                    Adi = "İçel"
                },
                new City
                {
                    Id = 48,
                    Kod = 48,
                    Adi = "Muğla"
                },
                new City
                {
                    Id = 49,
                    Kod = 49,
                    Adi = "Muş"
                },
                new City
                {
                    Id = 50,
                    Kod = 50,
                    Adi = "Nevşehir"
                },
                new City
                {
                    Id = 51,
                    Kod = 51,
                    Adi = "Niğde"
                },
                new City
                {
                    Id = 52,
                    Kod = 52,
                    Adi = "Ordu"
                },
                new City
                {
                    Id = 80,
                    Kod = 80,
                    Adi = "Osmaniye"
                },
                new City
                {
                    Id = 53,
                    Kod = 53,
                    Adi = "Rize"
                },
                new City
                {
                    Id = 55,
                    Kod = 55,
                    Adi = "Samsun"
                },
                new City
                {
                    Id = 54,
                    Kod = 54,
                    Adi = "Sakarya"
                },
                new City
                {
                    Id = 63,
                    Kod = 63,
                    Adi = "Şanlıurfa"
                },
                new City
                {
                    Id = 56,
                    Kod = 56,
                    Adi = "Siirt"
                },
                new City
                {
                    Id = 57,
                    Kod = 57,
                    Adi = "Sinop"
                },
                new City
                {
                    Id = 73,
                    Kod = 73,
                    Adi = "Şırnak"
                },
                new City
                {
                    Id = 58,
                    Kod = 58,
                    Adi = "Sivas"
                },
                new City
                {
                    Id = 59,
                    Kod = 59,
                    Adi = "Tekirdağ"
                },
                new City
                {
                    Id = 60,
                    Kod = 60,
                    Adi = "Tokat"
                },
                new City
                {
                    Id = 61,
                    Kod = 61,
                    Adi = "Trabzon"
                },
                new City
                {
                    Id = 62,
                    Kod = 62,
                    Adi = "Tunceli"
                },
                new City
                {
                    Id = 64,
                    Kod = 64,
                    Adi = "Uşak"
                },
                new City
                {
                    Id = 65,
                    Kod = 65,
                    Adi = "Van"
                },
                new City
                {
                    Id = 77,
                    Kod = 77,
                    Adi = "Yalova"
                },
                new City
                {
                    Id = 66,
                    Kod = 66,
                    Adi = "Yozgat"
                },
                new City
                {
                    Id = 67,
                    Kod = 67,
                    Adi = "Zonguldak"
                });


            #endregion

            #region İlçe

            // Adana
            List<string> ilceler =
                new List<string>(new string[]
                    {
                        "Aladağ", "Ceyhan", "Çukurova", "Feke", "İmamoğlu", "Karaisalı", "Karataş", "Kozan", "Pozantı",
                        "Saimbeyli", "Sarıçam", "Seyhan", "Tufanbeyli", "Yumurtalık", "Yüreğir"
                    });

            var counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 1,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);


            // Adıyaman
            ilceler = new List<string>(new string[]
                {
                "Adıyaman", "Besni", "Çelikhan", "Gerger", "Gölbaşı", "Kahta", "Samsat", "Sincik", "Tut"
                });
            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 2,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);


            // Afyon
            ilceler = new List<string>(new string[]
            {
            "Afyonkarahisar", "Başmakçı", "Bayat", "Bolvadin", "Çay", "Çobanlar", "Dazkırı", "Dinar", "Emirdağ", "Evciler", "Hocalar", "İhsaniye", "İscehisar", "Kızılören", "Sandıklı", "Sinanpaşa", "Sultandağı", "Şuhut"
            });
            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 3,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);


            // Ağrı
            ilceler = new List<string>(new string[]
            {
            "Ağrı", "Diyadin", "Doğubayazıt", "Eleşkirt", "Hamur", "Patnos", "Taşlıçay", "Tutak"
            });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 3,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Aksaray
            ilceler = new List<string>(new string[]
            {
            "Ağaçören", "Merkez", "Eskil", "Gülağaç", "Güzelyurt", "Ortaköy", "Sarıyahşi"
            });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 68,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Amasya
            ilceler = new List<string>(new string[]
            {
            "Amasya", "Göynücek", "Gümüşhacıköy", "Hamamözü", "Merzifon", "Suluova", "Taşova"
            });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 5,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Ankara
            ilceler = new List<string>(new string[]
                {
                "Altındağ", "Ayaş", "Bala", "Beypazarı", "Çamlıdere", "Çankaya", "Çubuk", "Elmadağ", "Güdül", "Haymana", "Kalecik", "Kızılcahamam", "Nallıhan", "Polatlı", "Şereflikoçhisar", "Yenimahalle", "Gölbaşı", "Keçiören", "Mamak", "Sincan", "Kazan", "Akyurt", "Etimesgut", "Evren", "Pursaklar"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 6,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Antalya
            ilceler = new List<string>(new string[]
                {
                "Akseki", "Aksu", "Alanya", "Demre", "Döşemealtı", "Elmalı", "Finike", "Gazipaşa", "Gündoğmuş", "İbradı", "Kaş", "Kemer", "Kepez", "Konyaaltı", "Korkuteli", "Kumluca", "Manavgat", "Muratpaşa", "Serik"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 7,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Artvin
            ilceler = new List<string>(new string[]
                {
                "Ardanuç", "Arhavi", "Artvin", "Merkez", "Borçka", "Hopa", "Şavşat", "Yusufeli", "Murgul"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 8,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Aydın
            ilceler = new List<string>(new string[]
                {
                "Bozdoğan", "Çine", "Germencik", "Karacasu", "Koçarlı", "Kuşadası", "Kuyucak", "Nazilli", "Söke", "Sultanhisar", "Yenipazar", "Buharkent", "İncirliova", "Karpuzlu", "Köşk", "Didim", "Efeler"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 9,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Balıkesir
            ilceler = new List<string>(new string[]
                {
            "Ayvalık", "Balya", "Bandırma", "Bigadiç", "Burhaniye", "Dursunbey", "Edremit", "Erdek", "Gönen", "Havran", "İvrindi", "Kepsut", "Manyas", "Savaştepe", "Sındırgı", "Susurluk", "Marmara", "Gömeç", "Altıeylül", "Karesi"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 10,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Bilecik
            ilceler = new List<string>(new string[]
                {
            "Merkez", "Bozüyük", "Gölpazarı", "Osmaneli", "Pazaryeri", "Söğüt", "Yenipazar", "İnhisar"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 11,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Bingöl
            ilceler = new List<string>(new string[]
                {
            "Merkez", "Genç", "Karlıova", "Kığı", "Solhan", "Adaklı", "Yayladere", "Yedisu"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 12,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Bitlis
            ilceler = new List<string>(new string[]
                {
            "Adilcevaz", "Ahlat", "Merkez", "Hizan", "Mutki", "Tatvan", "Güroymak"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 13,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Bolu
            ilceler = new List<string>(new string[]
                {
            "Merkez", "Gerede", "Göynük", "Kıbrıscık", "Mengen", "Mudurnu", "Seben", "Dörtdivan", "Yeniçağa"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 14,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Burdur
            ilceler = new List<string>(new string[]
                {
            "Ağlasun", "Bucak", "Merkez", "Gölhisar", "Tefenni", "Yeşilova", "Karamanlı", "Kemer", "Altınyayla", "Çavdır", "Çeltikçi"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 15,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Bursa
            ilceler = new List<string>(new string[]
                {
            "Gemlik", "İnegöl", "İznik", "Karacabey", "Keles", "Mudanya", "Mustafakemalpaşa", "Orhaneli", "Orhangazi", "Yenişehir", "Büyükorhan", "Harmancık", "Nilüfer", "Osmangazi", "Yıldırım", "Gürsu", "Kestel"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 16,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Çanakkale
            ilceler = new List<string>(new string[]
                {
            "Ayvacık", "Bayramiç", "Biga", "Bozcaada", "Çan", "Merkez", "Eceabat", "Ezine", "Gelibolu", "Lapseki", "Yenice"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 17,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Çankırı
            ilceler = new List<string>(new string[]
                {
            "Merkez", "Çerkeş", "Eldivan", "Ilgaz", "Kurşunlu", "Orta", "Şabanözü", "Yapraklı", "Atkaracalar", "Kızılırmak", "Bayramören", "Korgun"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 18,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Çorum
            ilceler = new List<string>(new string[]
                {
            "Alaca", "Bayat", "Merkez", "İskilip", "Kargı", "Mecitözü", "Ortaköy", "Osmancık", "Sungurlu", "Boğazkale", "Uğurludağ", "Dodurga", "Laçin", "Oğuzlar"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 19,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Denizli
            ilceler = new List<string>(new string[]
                {
            "Acıpayam", "Buldan", "Çal", "Çameli", "Çardak", "Çivril", "Güney", "Kale", "Sarayköy", "Tavas", "Babadağ", "Bekilli", "Honaz", "Serinhisar", "Pamukkale", "Baklan", "Beyağaç", "Bozkurt", "Merkezefendi"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 20,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            ilceler = new List<string>(new string[]
                {
            "Bismil", "Çermik", "Çınar", "Çüngüş", "Dicle", "Ergani", "Hani", "Hazro", "Kulp", "Lice", "Silvan", "Eğil", "Kocaköy", "Bağlar", "Kayapınar", "Sur", "Yenişehir"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 21,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Edirne
            ilceler = new List<string>(new string[]
                {
            "Merkez", "Enez", "Havsa", "İpsala", "Keşan", "Lalapaşa", "Meriç", "Uzunköprü", "Süloğlu"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 22,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Elazığ
            ilceler = new List<string>(new string[]
                {
            "Ağın", "Baskil", "Merkez", "Karakoçan", "Keban", "Maden", "Palu", "Sivrice", "Arıcak", "Kovancılar", "Alacakaya"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 23,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Erzincan
            ilceler = new List<string>(new string[]
                {
            "Çayırlı", "Merkez", "İliç", "Kemah", "Kemaliye", "Refahiye", "Tercan", "Üzümlü", "Otlukbeli"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 24,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Erzurum 
            ilceler = new List<string>(new string[]
                {
            "Aşkale", "Çat", "Hınıs", "Horasan", "İspir", "Karayazı", "Narman", "Oltu", "Olur", "Pasinler", "Şenkaya", "Tekman", "Tortum", "Karaçoban", "Uzundere", "Pazaryolu", "Aziziye", "Köprüköy", "Palandöken", "Yakutiye"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 25,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Eskişehir
            ilceler = new List<string>(new string[]
                {
            "Çifteler", "Mahmudiye", "Mihalıççık", "Sarıcakaya", "Seyitgazi", "Sivrihisar", "Alpu", "Beylikova", "İnönü", "Günyüzü", "Han", "Mihalgazi", "Odunpazarı", "Tepebaşı"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 26,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Gaziantep
            ilceler = new List<string>(new string[]
                {
            "Araban", "Islahiye", "Nizip", "Oğuzeli", "Yavuzeli", "Şahinbey", "Şehitkamil", "Karkamış", "Nurdağı"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 27,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Giresun
            ilceler = new List<string>(new string[]
                {
            "Alucra", "Bulancak", "Dereli", "Espiye", "Eynesil", "Merkez", "Görele", "Keşap", "Şebinkarahisar", "Tirebolu", "Piraziz", "Yağlıdere", "Çamoluk", "Çanakçı", "Doğankent", "Güce"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 28,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Gümüşhane
            ilceler = new List<string>(new string[]
                {
            "Merkez", "Kelkit", "Şiran", "Torul", "Köse", "Kürtün"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 29,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Hakkari
            ilceler = new List<string>(new string[]
                {
            "Çukurca", "Merkez", "Şemdinli", "Yüksekova"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 30,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Hatay
            ilceler = new List<string>(new string[]
                {
            "Altınözü", "Dörtyol", "Hassa", "İskenderun", "Kırıkhan", "Reyhanlı", "Samandağ", "Yayladağı", "Erzin", "Belen", "Kumlu", "Antakya", "Arsuz", "Defne", "Payas"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 31,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Isparta
            ilceler = new List<string>(new string[]
                {
            "Atabey", "Eğirdir", "Gelendost", "Merkez", "Keçiborlu", "Senirkent", "Sütçüler", "Şarkikırkağaç", "Uluborlu", "Yalvaç", "Aksu", "Gönen", "Yenişarbademli"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 32,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // İçel
            ilceler = new List<string>(new string[]
                {
            "Anamur", "Erdemli", "Gülnar", "Mut", "Silifke", "Tarsus", "Aydıncık", "Bozyazı", "Çamlıyayla", "Akdeniz", "Mezitli", "Toroslar", "Yenişehir"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 33,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // İstanbul
            ilceler = new List<string>(new string[]
                {
            "Adalar", "Bakırköy", "Beşiktaş", "Beykoz", "Beyoğlu", "Çatalca", "Eyüp", "Fatih", "Gaziosmanpaşa", "Kadıköy", "Kartal", "Sarıyer", "Silivri", "Şile", "Şişli", "Üsküdar", "Zeytinburnu", "Büyükçekmece", "Kağıthane", "Küçükçekmece", "Pendik", "Ümraniye", "Bayrampaşa", "Avcılar", "Bağcılar", "Bahçelievler", "Güngören", "Maltepe", "Sultanbeyli", "Tuzla", "Esenler", "Arnavutköy", "Ataşehir", "Başakşehir", "Beylikdüzü", "Çekmeköy", "Esenyurt", "Sancaktepe", "Sultangazi"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 34,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // İzmir
            ilceler = new List<string>(new string[]
                {
            "Aliağa", "Bayındır", "Bergama", "Bornova", "Çeşme", "Dikili", "Foça", "Karaburun", "Karşıyaka", "Kemalpaşa", "Kınık", "Kiraz", "Menemen", "Ödemiş", "Seferihisar", "Selçuk", "Tire", "Torbalı", "Urla", "Beydağ", "Buca", "Konak", "Menderes", "Balçova", "Çiğli", "Gaziemir", "Narlıdere", "Güzelbahçe", "Bayraklı", "Karabağlar"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 35,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Kars
            ilceler = new List<string>(new string[]
                {
            "Arpaçay", "Digor", "Kağızman", "Merkez", "Sarıkamış", "Selim", "Susuz", "Akyaka"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 36,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Kastamonu
            ilceler = new List<string>(new string[]
                {
            "Abana", "Araç", "Azdavay", "Bozkurt", "Cide", "Çatalzeytin", "Daday", "Devrekani", "İnebolu", "Merkez", "Küre", "Taşköprü", "Tosya", "İhsangazi", "Pınarbaşı", "Şenpazar", "Ağlı", "Doğanyurt", "Hanönü", "Seydiler"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 37,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Kayseri
            ilceler = new List<string>(new string[]
                {
            "Bünyan", "Develi", "Felahiye", "İncesu", "Pınarbaşı", "Sarıoğlan", "Sarız", "Tomarza", "Yahyalı", "Yeşilhisar", "Akkışla", "Talas", "Kocasinan", "Melikgazi", "Hacılar", "Özvatan"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 38,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Kırklareli
            ilceler = new List<string>(new string[]
                {
            "Babaeski", "Demirköy", "Merkez", "Kofçaz", "Lüleburgaz", "Pehlivanköy", "Pınarhisar", "Vize"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 39,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Kırşehir
            ilceler = new List<string>(new string[]
                {
            "Çiçekdağı", "Kaman", "Merkez", "Mucur", "Akpınar", "Akçakent", "Boztepe"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 40,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Kocaeli
            ilceler = new List<string>(new string[]
                {
            "Gebze", "Gölcük", "Kandıra", "Karamürsel", "Körfez", "Derince", "Başiskele", "Çayırova", "Darıca", "Dilovası", "İzmit", "Kartepe"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 41,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Konya
            ilceler = new List<string>(new string[]
                {
            "Akşehir", "Beyşehir", "Bozkır", "Cihanbeyli", "Çumra", "Doğanhisar", "Ereğli", "Hadim", "Ilgın", "Kadınhanı", "Karapınar", "Kulu", "Sarayönü", "Seydişehir", "Yunak", "Akören", "Altınekin", "Derebucak", "Hüyük", "Karatay", "Meram", "Selçuklu", "Taşkent", "Ahırlı", "Çeltik", "Derbent", "Emirgazi", "Güneysınır", "Halkapınar", "Tuzlukçu", "Yalıhüyük"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 42,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Kütahya
            ilceler = new List<string>(new string[]
                {
            "Altıntaş", "Domaniç", "Emet", "Gediz", "Merkez", "Simav", "Tavşanlı", "Aslanapa", "Dumlupınar", "Hisarcık", "Şaphane", "Çavdarhisar", "Pazarlar"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 43,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Malatya
            ilceler = new List<string>(new string[]
                {
            "Akçadağ", "Arapgir", "Arguvan", "Darende", "Doğanşehir", "Hekimhan", "Pütürge", "Yeşilyurt", "Battalgazi", "Doğanyol", "Kale", "Kuluncak", "Yazıhan"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 44,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            //Manisa
            ilceler = new List<string>(new string[]
                {
            "Akhisar", "Alaşehir", "Demirci", "Gördes", "Kırkağaç", "Kula", "Salihli", "Sarıgöl", "Saruhanlı", "Selendi", "Soma", "Turgutlu", "Ahmetli", "Gölmarmara", "Köprübaşı", "Şehzadeler", "Yunusemre"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 45,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Maraş
            ilceler = new List<string>(new string[]
                {
            "Afşin", "Andırın", "Elbistan", "Göksun", "Pazarcık", "Türkoğlu", "Çağlayancerit", "Ekinözü", "Nurhak", "Dulkadiroğlu", "Onikişubat"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 46,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Mardin
            ilceler = new List<string>(new string[]
                {
            "Derik", "Kızıltepe", "Mazıdağı", "Midyat", "Nusaybin", "Ömerli", "Savur", "Dargeçit", "Yeşilli", "Artuklu"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 47,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Muğla
            ilceler = new List<string>(new string[]
                {
            "Bodrum", "Datça", "Fethiye", "Köyceğiz", "Marmaris", "Milas", "Ula", "Yatağan", "Dalaman", "Ortaca", "Kavaklıdere", "Menteşe", "Seydikemer"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 48,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Muş
            ilceler = new List<string>(new string[]
                {
            "Bulanık", "Malazgirt", "Merkez", "Varto", "Hasköy", "Korkut"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 49,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Nevşehir
            ilceler = new List<string>(new string[]
                {
            "Avanos", "Derinkuyu", "Gülşehir", "Hacıbektaş", "Kozaklı", "Merkez", "Ürgüp", "Acıgöl"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 50,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Niğde
            ilceler = new List<string>(new string[]
                {
            "Bor", "Çamardı", "Merkez", "Ulukışla", "Altunhisar", "Çiftlik"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 51,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Ordu
            ilceler = new List<string>(new string[]
                {
            "Akkuş", "Aybastı", "Fatsa", "Gölköy", "Korgan", "Kumru", "Mesudiye", "Perşembe", "Ulubey", "Ünye", "Gülyalı", "Gürgentepe", "Çamaş", "Çatalpınar", "Çaybaşı", "İkizce", "Kabadüz", "Kabataş", "Altınordu"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 52,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Rize
            ilceler = new List<string>(new string[]
                {
            "Ardeşen", "Çamlıhemşin", "Çayeli", "Fındıklı", "İkizdere", "Kalkandere", "Pazar", "Merkez", "Güneysu", "Derepazarı", "Hemşin", "İyidere"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 53,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Sakarya
            ilceler = new List<string>(new string[]
                {
            "Akyazı", "Geyve", "Hendek", "Karasu", "Kaynarca", "Sapanca", "Kocaali", "Pamukova", "Taraklı", "Ferizli", "Karapürçek", "Söğütlü", "Adapazarı", "Arifiye", "Erenler", "Serdivan"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 54,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Samsun 
            ilceler = new List<string>(new string[]
                {
            "Alaçam", "Bafra", "Çarşamba", "Havza", "Kavak", "Ladik", "Terme", "Vezirköprü", "Asarcık", "19 Mayıs", "Salıpazarı", "Tekkeköy", "Ayvacık", "Yakakent", "Atakum", "Canik", "İlkadım"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 55,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Siirt
            ilceler = new List<string>(new string[]
                {
            "Baykan", "Eruh", "Kurtalan", "Pervari", "Merkez", "Şirvan", "Tillo"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 56,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Sinop
            ilceler = new List<string>(new string[]
                {
            "Ayancık", "Boyabat", "Durağan", "Erfelek", "Gerze", "Merkez", "Türkeli", "Dikmen", "Saraydüzü"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 57,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Sivas    
            ilceler = new List<string>(new string[]
                {
            "Divriği", "Gemerek", "Gürün", "Hafik", "İmranlı", "Kangal", "Koyulhisar", "Merkez", "Suşehri", "Şarkışla", "Yıldızeli", "Zara", "Akıncılar", "Altınyayla", "Doğanşar", "Gölova", "Ulaş"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 58,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Tekirdağ
            ilceler = new List<string>(new string[]
                {
            "Çerkezköy", "Çorlu", "Hayrabolu", "Malkara", "Muratlı", "Saray", "Şarköy", "Marmaraereğlisi", "Ergene", "Süleymanpaşa"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 59,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Tokat
            ilceler = new List<string>(new string[]
                {
            "Almus", "Artova", "Erbaa", "Niksar", "Reşadiye", "Merkez", "Turhal", "Zile", "Pazar", "Yeşilyurt", "Başçiftlik", "Sulusaray"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 60,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Trabzon
            ilceler = new List<string>(new string[]
                {
            "Akçaabat", "Araklı", "Arsin", "Çaykara", "Maçka", "Of", "Sürmene", "Tonya", "Vakfıkebir", "Yomra", "Beşikdüzü", "Şalpazarı", "Çarşıbaşı", "Dernekpazarı", "Düzköy", "Hayrat", "Köprübaşı", "Ortahisar"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 61,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Tunceli
            ilceler = new List<string>(new string[]
                {
            "Çemişgezek", "Hozat", "Malazgirt", "Nazımiye", "Ovacık", "Pertek", "Pülümür", "Merkez"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 62,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Urfa
            ilceler = new List<string>(new string[]
                {
            "Akçakale", "Birecik", "Bozova", "Ceylanpınar", "Halfeti", "Hilvan", "Siverek", "Suruç", "Viranşehir", "Harran", "Eyyübiye", "Haliliye", "Karaköprü"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 63,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Uşak
            ilceler = new List<string>(new string[]
                {
            "Banaz", "Eşme", "Karahallı", "Sivaslı", "Ulubey", "Merkez"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 64,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Van
            ilceler = new List<string>(new string[]
                {
            "Başkale", "Çatak", "Erciş", "Gevaş", "Gürpınar", "Muradiye", "Özalp", "Bahçesaray", "Çaldıran", "Edremit", "Saray", "İpekyolu", "Tuşba"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 65,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Yozgat
            ilceler = new List<string>(new string[]
                {
            "Akdağmadeni", "Boğazlıyan", "Çayıralan", "Çekerek", "Sarıkaya", "Sorgun", "Şefaatli", "Yerköy", "Merkez", "Aydıncık", "Çandır", "Kadışehri", "Saraykent", "Yenifakılı"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 66,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Zonguldak
            ilceler = new List<string>(new string[]
                {
            "Çaycuma", "Devrek", "Ereğli", "Merkez", "Alaplı", "Gökçebey"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 67,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Bayburt
            ilceler = new List<string>(new string[]
                {
            "Merkez", "Aydıntepe", "Demirözü"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 69,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Karaman
            ilceler = new List<string>(new string[]
                {
            "Ermenek", "Merkez", "Ayrancı", "Kazımkarabekir", "Başyayla", "Sarıveliler"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 70,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Kırıkkale
            ilceler = new List<string>(new string[]
                {
            "Delice", "Keskin", "Merkez", "Sulakyurt", "Bahşili", "Balışeyh", "Çelebi", "Karakeçili", "Yahşihan"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 71,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Batman
            ilceler = new List<string>(new string[]
                {
            "Merkez", "Beşiri", "Gercüş", "Kozluk", "Sason", "Hasankeyf"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 72,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Şırnak
            ilceler = new List<string>(new string[]
                {
            "Beytüşşebap", "Cizre", "İdil", "Silopi", "Merkez", "Uludere", "Güçlükonak"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 73,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Bartın
            ilceler = new List<string>(new string[]
                {
            "Merkez", "Kurucaşile", "Ulus", "Amasra"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 74,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Ardahan
            ilceler = new List<string>(new string[]
                {
            "Merkez", "Çıldır", "Göle", "Hanak", "Posof", "Damal"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 75,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Iğdır
            ilceler = new List<string>(new string[]
                {
            "Aralık", "Merkez", "Tuzluca", "Karakoyunlu"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 76,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Yalova
            ilceler = new List<string>(new string[]
                {
            "Merkez", "Altınova", "Armutlu", "Çınarcık", "Çiftlikköy", "Termal"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 77,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Karabük
            ilceler = new List<string>(new string[]
                {
            "Eflani", "Eskipazar", "Merkez", "Ovacık", "Safranbolu", "Yenice"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 78,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Kilis
            ilceler = new List<string>(new string[]
                {
            "Merkez", "Elbeyli", "Musabeyli", "Polateli"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 79,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Osmaniye
            ilceler = new List<string>(new string[]
                {
            "Bahçe", "Kadirli", "Merkez", "Düziçi", "Hasanbeyli", "Sumbas", "Toprakkale"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 80,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            // Düzce
            ilceler = new List<string>(new string[]
                {
            "Akçakoca", "Merkez", "Yığılca", "Cumayeri", "Gölyaka", "Çilimli", "Gümüşova", "Kaynaşlı"
                });

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Adi = ilceler[i],
                    CityId = 81,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            #endregion

            #region User

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "İlhan",
                    LastName = "ALTIN",
                    Email = "ilhanaltin@gmail.com",
                    IsBlocked = false,
                    NickName = "ilhanaltin",
                    Password = "e44f5f0bf7a453a731217f288641ab16",
                    CreatedDateTime = DateTime.Now,
                    UserLoginTypeId = 1,
                    CreatedUserId = 1,
                    UserStatusTypeId = 1,
                    UpdatedUserId = null,
                    SocialMediaUserId = null,
                    UpdatedDateTime = null
                },
                new User
                {
                    Id = 2,
                    Name = "Yiğityürek",
                    LastName = "ALTIN",
                    Email = "yya@gmail.com",
                    IsBlocked = false,
                    NickName = "yigit",
                    Password = "e44f5f0bf7a453a731217f288641ab16",
                    CreatedDateTime = DateTime.Now,
                    UserLoginTypeId = 1,
                    CreatedUserId = 1,
                    UserStatusTypeId = 1,
                    UpdatedUserId = null,
                    SocialMediaUserId = null,
                    UpdatedDateTime = null
                },
                new User
                {
                    Id = 3,
                    Name = "Ali Veli",
                    LastName = "KONYA",
                    Email = "alivelikonya@gmail.com",
                    IsBlocked = false,
                    NickName = "alivelikonya",
                    Password = "e44f5f0bf7a453a731217f288641ab16",
                    CreatedDateTime = DateTime.Now,
                    UserLoginTypeId = 1,
                    CreatedUserId = 1,
                    UserStatusTypeId = 1,
                    UpdatedUserId = null,
                    SocialMediaUserId = null,
                    UpdatedDateTime = null
                },
                new User
                {
                    Id = 4,
                    Name = "Ahmet",
                    LastName = "KOÇ",
                    Email = "kocahmet@msn.com",
                    IsBlocked = false,
                    NickName = "kocero",
                    Password = "e44f5f0bf7a453a731217f288641ab16",
                    CreatedDateTime = DateTime.Now,
                    UserLoginTypeId = 1,
                    CreatedUserId = 1,
                    UserStatusTypeId = 1,
                    UpdatedUserId = null,
                    SocialMediaUserId = null,
                    UpdatedDateTime = null
                },
                new User
                {
                    Id = 5,
                    Name = "KATANA",
                    LastName = "SAPI",
                    Email = "katanasapi@gmail.com",
                    IsBlocked = false,
                    NickName = "katanasapi",
                    Password = "ad9187d4c31d650f97bbfecb52189053",
                    CreatedDateTime = DateTime.Now,
                    UserLoginTypeId = 1,
                    CreatedUserId = 1,
                    UserStatusTypeId = 1,
                    UpdatedUserId = null,
                    SocialMediaUserId = null,
                    UpdatedDateTime = null
                },
                new User
                {
                    Id = 6,
                    Name = "METIN",
                    LastName = "OLYAVRUM",
                    Email = "metinolyavrum@gmail.com",
                    IsBlocked = false,
                    NickName = "SenBen",
                    Password = "9456066bcb14f5c1fa388fda6310f38f",
                    CreatedDateTime = DateTime.Now,
                    UserLoginTypeId = 1,
                    CreatedUserId = 1,
                    UserStatusTypeId = 1,
                    UpdatedUserId = null,
                    SocialMediaUserId = null,
                    UpdatedDateTime = null
                },
                new User
                {
                    Id = 7,
                    Name = "HAS",
                    LastName = "DURUYI",
                    Email = "hasduruyi@outlook.com.tr",
                    IsBlocked = false,
                    NickName = "HASDURUYI",
                    Password = "6c6e2722c24fd0c5d5153732c0776830",
                    CreatedDateTime = DateTime.Now,
                    UserLoginTypeId = 1,
                    CreatedUserId = 1,
                    UserStatusTypeId = 1,
                    UpdatedUserId = null,
                    SocialMediaUserId = null,
                    UpdatedDateTime = null
                },
                new User
                {
                    Id = 8,
                    Name = "Ömer",
                    LastName = "MERMER",
                    Email = "mermeresican@gmail.com",
                    IsBlocked = false,
                    NickName = "mermeromer",
                    Password = "6d071901727aec1ba6d8e2497ef5b709",
                    CreatedDateTime = DateTime.Now,
                    UserLoginTypeId = 1,
                    CreatedUserId = 1,
                    UserStatusTypeId = 1,
                    UpdatedUserId = null,
                    SocialMediaUserId = null,
                    UpdatedDateTime = null
                },
                new User
                {
                    Id = 9,
                    Name = "HACI",
                    LastName = "BABATEKKESI",
                    Email = "hacilarageldik@gmail.com",
                    IsBlocked = false,
                    NickName = "ozontabakasi",
                    Password = "ad9187d4c31d650f97bbfecb52189053",
                    CreatedDateTime = DateTime.Now,
                    UserLoginTypeId = 2,
                    CreatedUserId = 1,
                    UserStatusTypeId = 1,
                    UpdatedUserId = null,
                    SocialMediaUserId = "111423556560295556670",
                    UpdatedDateTime = null
                },
                new User
                {
                    Id = 10,
                    Name = "Firavun",
                    LastName = "YELLENIR",
                    Email = "yellenenfiravun@gmail.com",
                    IsBlocked = false,
                    NickName = "yellos",
                    Password = "64fead8f0a346037b7d1f3247fffa33d",
                    CreatedDateTime = DateTime.Now,
                    UserLoginTypeId = 1,
                    CreatedUserId = 1,
                    UserStatusTypeId = 1,
                    UpdatedUserId = null,
                    SocialMediaUserId = null,
                    UpdatedDateTime = null
                }
            );

            #endregion

            #region UserRole

            modelBuilder.Entity<UserRole>().HasData(
                new UserRole
                {
                    Id = 1,
                    UserId = 1,
                    RoleTypeId = 1,
                    CreatedDateTime = DateTime.Now,
                    CreatedUserId = 1,
                    UpdatedDateTime = null,
                    UpdatedUserId = null
                },
                new UserRole
                {
                    Id = 2,
                    UserId = 2,
                    RoleTypeId = 1,
                    CreatedDateTime = DateTime.Now,
                    CreatedUserId = 1,
                    UpdatedDateTime = null,
                    UpdatedUserId = null
                },
                new UserRole
                {
                    Id = 3,
                    UserId = 3,
                    RoleTypeId = 2,
                    CreatedDateTime = DateTime.Now,
                    CreatedUserId = 1,
                    UpdatedDateTime = null,
                    UpdatedUserId = null
                },
                new UserRole
                {
                    Id = 4,
                    UserId = 4,
                    RoleTypeId = 2,
                    CreatedDateTime = DateTime.Now,
                    CreatedUserId = 1,
                    UpdatedDateTime = null,
                    UpdatedUserId = null
                },
                new UserRole
                {
                    Id = 5,
                    UserId = 5,
                    RoleTypeId = 2,
                    CreatedDateTime = DateTime.Now,
                    CreatedUserId = 1,
                    UpdatedDateTime = null,
                    UpdatedUserId = null
                },
                new UserRole
                {
                    Id = 6,
                    UserId = 6,
                    RoleTypeId = 2,
                    CreatedDateTime = DateTime.Now,
                    CreatedUserId = 1,
                    UpdatedDateTime = null,
                    UpdatedUserId = null
                },
                 new UserRole
                 {
                     Id = 7,
                     UserId = 7,
                     RoleTypeId = 2,
                     CreatedDateTime = DateTime.Now,
                     CreatedUserId = 1,
                     UpdatedDateTime = null,
                     UpdatedUserId = null
                 },
                 new UserRole
                 {
                     Id = 8,
                     UserId = 8,
                     RoleTypeId = 2,
                     CreatedDateTime = DateTime.Now,
                     CreatedUserId = 1,
                     UpdatedDateTime = null,
                     UpdatedUserId = null
                 },
                  new UserRole
                  {
                      Id = 9,
                      UserId = 9,
                      RoleTypeId = 2,
                      CreatedDateTime = DateTime.Now,
                      CreatedUserId = 1,
                      UpdatedDateTime = null,
                      UpdatedUserId = null
                  },
                  new UserRole
                  {
                      Id = 10,
                      UserId = 10,
                      RoleTypeId = 2,
                      CreatedDateTime = DateTime.Now,
                      CreatedUserId = 1,
                      UpdatedDateTime = null,
                      UpdatedUserId = null
                  }
             );

            #endregion
        }
    }
}
