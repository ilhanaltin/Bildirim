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

            #region Country

            modelBuilder.Entity<Country>().HasData(
                new Country { Id = 1, Adi = "Türkiye", CreatedDateTime = DateTime.Today, CreatedUserId = 1, UpdatedDateTime = null, UpdatedUserId = null },
                new Country { Id = 2, Adi = "Amerika", CreatedDateTime = DateTime.Today, CreatedUserId = 1, UpdatedDateTime = null, UpdatedUserId = null },
                new Country { Id = 3, Adi = "Almanya", CreatedDateTime = DateTime.Today, CreatedUserId = 1, UpdatedDateTime = null, UpdatedUserId = null }
            );

            #endregion

            #region Company

            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Adi = "Garanti Bankası", CountryId=1, CreatedDateTime = DateTime.Today, CreatedUserId = 1, UpdatedDateTime = null, UpdatedUserId = null },
                new Company { Id = 2, Adi = "İş Bankası", CountryId = 1, CreatedDateTime = DateTime.Today, CreatedUserId = 1, UpdatedDateTime = null, UpdatedUserId = null },
                new Company { Id = 3, Adi = "Media Markt", CountryId = 1, CreatedDateTime = DateTime.Today, CreatedUserId = 1, UpdatedDateTime = null, UpdatedUserId = null }
            );

            #endregion

            #region İl

            modelBuilder.Entity<City>().HasData(
                new City
                {
                    Id = 1,
                    CountryId = 1,
                    Adi = "Adana",
                    Kod = 1,
                },
                new City
                {
                    Id = 2,
                    CountryId = 1,
                    Adi = "Adıyaman",
                    Kod = 2
                },
                new City
                {
                    Id = 3,
                    CountryId = 1,
                    Adi = "Afyon",
                    Kod = 3
                },
                new City
                {
                    Id = 4,
                    CountryId = 1,
                    Adi = "Ağrı",
                    Kod = 4
                },
                new City
                {
                    Id = 5,
                    CountryId = 1,
                    Adi = "Amasya",
                    Kod = 5
                },
                new City
                {
                    Id = 6,
                    CountryId = 1,
                    Adi = "Ankara",
                    Kod = 6
                },
                new City
                {
                    Id = 7,
                    CountryId = 1,
                    Adi = "Antalya",
                    Kod = 7
                },
                new City
                {
                    Id = 8,
                    CountryId = 1,
                    Kod = 8,
                    Adi = "Artvin"
                },
                new City
                {
                    Adi = "Aydın",
                    Id = 9,
                    CountryId = 1,
                    Kod = 9
                },
                new City
                {
                    Adi = "Balıkesir",
                    Id = 10,
                    CountryId = 1,
                    Kod = 10
                },
                new City
                {
                    Id = 11,
                    CountryId = 1,
                    Kod = 11,
                    Adi = "Bilecik"
                },
                new City
                {
                    Id = 12,
                    CountryId = 1,
                    Kod = 12,
                    Adi = "Bingöl"
                },
                new City
                {
                    Id = 13,
                    CountryId = 1,
                    Kod = 13,
                    Adi = "Bitlis"
                },
                new City
                {
                    Id = 14,
                    CountryId = 1,
                    Kod = 14,
                    Adi = "Bolu"
                },
                new City
                {
                    Id = 15,
                    CountryId = 1,
                    Kod = 15,
                    Adi = "Burdur"
                },
                new City
                {
                    Id = 16,
                    CountryId = 1,
                    Kod = 16,
                    Adi = "Bursa"
                },
                new City
                {
                    Id = 17,
                    CountryId = 1,
                    Kod = 17,
                    Adi = "Çanakkale"
                },
                new City
                {
                    Id = 18,
                    CountryId = 1,
                    Kod = 18,
                    Adi = "Çankırı"
                },
                new City
                {
                    Id = 19,
                    CountryId = 1,
                    Kod = 19,
                    Adi = "Çorum"
                },
                new City
                {
                    Id = 20,
                    CountryId = 1,
                    Kod = 20,
                    Adi = "Denizli"
                },
                new City
                {
                    Id = 21,
                    CountryId = 1,
                    Kod = 21,
                    Adi = "Diyarbakır"
                },
                new City
                {
                    Id = 22,
                    CountryId = 1,
                    Kod = 22,
                    Adi = "Edirne"
                },
                new City
                {
                    Id = 23,
                    CountryId = 1,
                    Kod = 23,
                    Adi = "Elazığ"
                },
                new City
                {
                    Id = 24,
                    CountryId = 1,
                    Kod = 24,
                    Adi = "Erzincan"
                },
                new City
                {
                    Id = 25,
                    CountryId = 1,
                    Kod = 25,
                    Adi = "Erzurum"
                },
                new City
                {
                    Id = 26,
                    CountryId = 1,
                    Kod = 26,
                    Adi = "Eskişehir"
                },
                new City
                {
                    Id = 27,
                    CountryId = 1,
                    Kod = 27,
                    Adi = "Gaziantep"
                },
                new City
                {
                    Id = 28,
                    CountryId = 1,
                    Kod = 28,
                    Adi = "Giresun"
                },
                new City
                {
                    Id = 29,
                    CountryId = 1,
                    Kod = 29,
                    Adi = "Gümüşhane"
                },
                new City
                {
                    Id = 30,
                    CountryId = 1,
                    Kod = 30,
                    Adi = "Hakkari"
                },
                new City
                {
                    Id = 31,
                    CountryId = 1,
                    Kod = 31,
                    Adi = "Hatay"
                },
                new City
                {
                    Id = 32,
                    CountryId = 1,
                    Kod = 32,
                    Adi = "Isparta"
                },
                new City
                {
                    Id = 33,
                    CountryId = 1,
                    Kod = 33,
                    Adi = "İçel"
                },
                new City
                {
                    Id = 34,
                    CountryId = 1,
                    Kod = 34,
                    Adi = "İstanbul"
                },
                new City
                {
                    Id = 35,
                    CountryId = 1,
                    Kod = 35,
                    Adi = "İzmir"
                },
                new City
                {
                    Id = 36,
                    CountryId = 1,
                    Kod = 36,
                    Adi = "Kars"
                },
                new City
                {
                    Id = 37,
                    CountryId = 1,
                    Kod = 37,
                    Adi = "Kastamonu"
                },
                new City
                {
                    Id = 38,
                    CountryId = 1,
                    Kod = 38,
                    Adi = "Kayseri"
                },
                new City
                {
                    Id = 39,
                    CountryId = 1,
                    Kod = 39,
                    Adi = "Kırklareli"
                },
                new City
                {
                    Id = 40,
                    CountryId = 1,
                    Kod = 40,
                    Adi = "Kırşehir"
                },
                new City
                {
                    Id = 41,
                    CountryId = 1,
                    Kod = 41,
                    Adi = "Kocaeli"
                },
                new City
                {
                    Id = 42,
                    CountryId = 1,
                    Kod = 42,
                    Adi = "Konya"
                },
                new City
                {
                    Id = 43,
                    CountryId = 1,
                    Kod = 43,
                    Adi = "Kütahya"
                },
                new City
                {
                    Id = 44,
                    CountryId = 1,
                    Kod = 44,
                    Adi = "Malatya"
                },
                new City
                {
                    Id = 45,
                    CountryId = 1,
                    Kod = 45,
                    Adi = "Manisa"
                },
                new City
                {
                    Id = 46,
                    CountryId = 1,
                    Kod = 46,
                    Adi = "Kahramanmaraş"
                },
                new City
                {
                    Id = 47,
                    CountryId = 1,
                    Kod = 47,
                    Adi = "Mardin"
                },
                new City
                {
                    Id = 48,
                    CountryId = 1,
                    Kod = 48,
                    Adi = "Muğla"
                },
                new City
                {
                    Id = 49,
                    CountryId = 1,
                    Kod = 49,
                    Adi = "Muş"
                },
                new City
                {
                    Id = 50,
                    CountryId = 1,
                    Kod = 50,
                    Adi = "Nevşehir"
                },
                new City
                {
                    Id = 51,
                    CountryId = 1,
                    Kod = 51,
                    Adi = "Niğde"
                },
                new City
                {
                    Id = 52,
                    CountryId = 1,
                    Kod = 52,
                    Adi = "Ordu"
                },
                new City
                {
                    Id = 53,
                    CountryId = 1,
                    Kod = 53,
                    Adi = "Rize"
                },
                new City
                {
                    Id = 54,
                    CountryId = 1,
                    Kod = 54,
                    Adi = "Sakarya"
                },
                new City
                {
                    Id = 55,
                    CountryId = 1,
                    Kod = 55,
                    Adi = "Samsun"
                },
                new City
                {
                    Id = 56,
                    CountryId = 1,
                    Kod = 56,
                    Adi = "Siirt"
                },
                new City
                {
                    Id = 57,
                    CountryId = 1,
                    Kod = 57,
                    Adi = "Sinop"
                },
                new City
                {
                    Id = 58,
                    CountryId = 1,
                    Kod = 58,
                    Adi = "Sivas"
                },
                new City
                {
                    Id = 59,
                    CountryId = 1,
                    Kod = 59,
                    Adi = "Tekirdağ"
                },
                new City
                {
                    Id = 60,
                    CountryId = 1,
                    Kod = 60,
                    Adi = "Tokat"
                },
                new City
                {
                    Id = 61,
                    CountryId = 1,
                    Kod = 61,
                    Adi = "Trabzon"
                },
                new City
                {
                    Id = 62,
                    CountryId = 1,
                    Kod = 62,
                    Adi = "Tunceli"
                },
                new City
                {
                    Id = 63,
                    CountryId = 1,
                    Kod = 63,
                    Adi = "Şanlıurfa"
                },
                new City
                {
                    Id = 64,
                    CountryId = 1,
                    Kod = 64,
                    Adi = "Uşak"
                },
                new City
                {
                    Id = 65,
                    CountryId = 1,
                    Kod = 65,
                    Adi = "Van"
                },
                new City
                {
                    Id = 66,
                    CountryId = 1,
                    Kod = 66,
                    Adi = "Yozgat"
                },
                new City
                {
                    Id = 67,
                    CountryId = 1,
                    Kod = 67,
                    Adi = "Zonguldak"
                },
                 new City
                 {
                     Id = 68,
                     CountryId = 1,
                     Adi = "Aksaray",
                     Kod = 68
                 },
                 new City
                 {
                     Id = 69,
                     CountryId = 1,
                     Kod = 69,
                     Adi = "Bayburt"
                 },
                 new City
                 {
                     Id = 70,
                     CountryId = 1,
                     Kod = 70,
                     Adi = "Karaman"
                 },
                 new City
                 {
                     Id = 71,
                     CountryId = 1,
                     Kod = 71,
                     Adi = "Kırıkkale"
                 },
                new City
                {
                    Id = 72,
                    CountryId = 1,
                    Kod = 72,
                    Adi = "Batman"
                },
                new City
                {
                    Id = 73,
                    CountryId = 1,
                    Kod = 73,
                    Adi = "Şırnak"
                },
                new City
                {
                    Id = 74,
                    CountryId = 1,
                    Kod = 74,
                    Adi = "Bartın"
                },
                new City
                {
                    Id = 75,
                    CountryId = 1,
                    Kod = 75,
                    Adi = "Ardahan"
                },
                new City
                {
                    Id = 76,
                    CountryId = 1,
                    Kod = 76,
                    Adi = "Iğdır"
                },
                new City
                {
                    Id = 77,
                    CountryId = 1,
                    Kod = 77,
                    Adi = "Yalova"
                },
                new City
                {
                    Id = 78,
                    CountryId = 1,
                    Kod = 78,
                    Adi = "Karabük"
                },
                new City
                {
                    Id = 79,
                    CountryId = 1,
                    Kod = 79,
                    Adi = "Kilis"
                },
                new City
                {
                    Id = 80,
                    CountryId = 1,
                    Kod = 80,
                    Adi = "Osmaniye"
                },
                new City
                {
                    Id = 81,
                    CountryId = 1,
                    Kod = 81,
                    Adi = "Düzce"
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
                    Id = i + 1,
                    Adi = ilceler[i],
                    CityId = 1,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            int index = ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 2,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties);

            index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 3,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;


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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 3,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 68,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 5,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 6,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 7,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 8,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 9,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 10,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 11,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 12,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 13,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 14,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 15,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 16,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 17,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 18,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 19,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 20,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            ilceler = new List<string>(new string[]
                {
            "Bismil", "Çermik", "Çınar", "Çüngüş", "Dicle", "Ergani", "Hani", "Hazro", "Kulp", "Lice", "Silvan", "Eğil", "Kocaköy", "Bağlar", "Kayapınar", "Sur", "Yenişehir"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 21,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 22,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 23,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 24,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 25,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 26,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 27,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 28,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 29,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 30,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 31,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 32,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 33,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 34,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 35,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 36,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 37,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 38,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 39,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

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
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 40,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Kocaeli
            ilceler = new List<string>(new string[]
                {
            "Gebze", "Gölcük", "Kandıra", "Karamürsel", "Körfez", "Derince", "Başiskele", "Çayırova", "Darıca", "Dilovası", "İzmit", "Kartepe"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 41,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Konya
            ilceler = new List<string>(new string[]
                {
            "Akşehir", "Beyşehir", "Bozkır", "Cihanbeyli", "Çumra", "Doğanhisar", "Ereğli", "Hadim", "Ilgın", "Kadınhanı", "Karapınar", "Kulu", "Sarayönü", "Seydişehir", "Yunak", "Akören", "Altınekin", "Derebucak", "Hüyük", "Karatay", "Meram", "Selçuklu", "Taşkent", "Ahırlı", "Çeltik", "Derbent", "Emirgazi", "Güneysınır", "Halkapınar", "Tuzlukçu", "Yalıhüyük"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 42,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Kütahya
            ilceler = new List<string>(new string[]
                {
            "Altıntaş", "Domaniç", "Emet", "Gediz", "Merkez", "Simav", "Tavşanlı", "Aslanapa", "Dumlupınar", "Hisarcık", "Şaphane", "Çavdarhisar", "Pazarlar"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 43,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Malatya
            ilceler = new List<string>(new string[]
                {
            "Akçadağ", "Arapgir", "Arguvan", "Darende", "Doğanşehir", "Hekimhan", "Pütürge", "Yeşilyurt", "Battalgazi", "Doğanyol", "Kale", "Kuluncak", "Yazıhan"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 44,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            //Manisa
            ilceler = new List<string>(new string[]
                {
            "Akhisar", "Alaşehir", "Demirci", "Gördes", "Kırkağaç", "Kula", "Salihli", "Sarıgöl", "Saruhanlı", "Selendi", "Soma", "Turgutlu", "Ahmetli", "Gölmarmara", "Köprübaşı", "Şehzadeler", "Yunusemre"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 45,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Maraş
            ilceler = new List<string>(new string[]
                {
            "Afşin", "Andırın", "Elbistan", "Göksun", "Pazarcık", "Türkoğlu", "Çağlayancerit", "Ekinözü", "Nurhak", "Dulkadiroğlu", "Onikişubat"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 46,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Mardin
            ilceler = new List<string>(new string[]
                {
            "Derik", "Kızıltepe", "Mazıdağı", "Midyat", "Nusaybin", "Ömerli", "Savur", "Dargeçit", "Yeşilli", "Artuklu"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 47,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Muğla
            ilceler = new List<string>(new string[]
                {
            "Bodrum", "Datça", "Fethiye", "Köyceğiz", "Marmaris", "Milas", "Ula", "Yatağan", "Dalaman", "Ortaca", "Kavaklıdere", "Menteşe", "Seydikemer"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 48,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Muş
            ilceler = new List<string>(new string[]
                {
            "Bulanık", "Malazgirt", "Merkez", "Varto", "Hasköy", "Korkut"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 49,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Nevşehir
            ilceler = new List<string>(new string[]
                {
            "Avanos", "Derinkuyu", "Gülşehir", "Hacıbektaş", "Kozaklı", "Merkez", "Ürgüp", "Acıgöl"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 50,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Niğde
            ilceler = new List<string>(new string[]
                {
            "Bor", "Çamardı", "Merkez", "Ulukışla", "Altunhisar", "Çiftlik"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 51,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Ordu
            ilceler = new List<string>(new string[]
                {
            "Akkuş", "Aybastı", "Fatsa", "Gölköy", "Korgan", "Kumru", "Mesudiye", "Perşembe", "Ulubey", "Ünye", "Gülyalı", "Gürgentepe", "Çamaş", "Çatalpınar", "Çaybaşı", "İkizce", "Kabadüz", "Kabataş", "Altınordu"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 52,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Rize
            ilceler = new List<string>(new string[]
                {
            "Ardeşen", "Çamlıhemşin", "Çayeli", "Fındıklı", "İkizdere", "Kalkandere", "Pazar", "Merkez", "Güneysu", "Derepazarı", "Hemşin", "İyidere"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 53,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Sakarya
            ilceler = new List<string>(new string[]
                {
            "Akyazı", "Geyve", "Hendek", "Karasu", "Kaynarca", "Sapanca", "Kocaali", "Pamukova", "Taraklı", "Ferizli", "Karapürçek", "Söğütlü", "Adapazarı", "Arifiye", "Erenler", "Serdivan"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 54,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Samsun 
            ilceler = new List<string>(new string[]
                {
            "Alaçam", "Bafra", "Çarşamba", "Havza", "Kavak", "Ladik", "Terme", "Vezirköprü", "Asarcık", "19 Mayıs", "Salıpazarı", "Tekkeköy", "Ayvacık", "Yakakent", "Atakum", "Canik", "İlkadım"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 55,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Siirt
            ilceler = new List<string>(new string[]
                {
            "Baykan", "Eruh", "Kurtalan", "Pervari", "Merkez", "Şirvan", "Tillo"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 56,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Sinop
            ilceler = new List<string>(new string[]
                {
            "Ayancık", "Boyabat", "Durağan", "Erfelek", "Gerze", "Merkez", "Türkeli", "Dikmen", "Saraydüzü"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 57,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Sivas    
            ilceler = new List<string>(new string[]
                {
            "Divriği", "Gemerek", "Gürün", "Hafik", "İmranlı", "Kangal", "Koyulhisar", "Merkez", "Suşehri", "Şarkışla", "Yıldızeli", "Zara", "Akıncılar", "Altınyayla", "Doğanşar", "Gölova", "Ulaş"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 58,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Tekirdağ
            ilceler = new List<string>(new string[]
                {
            "Çerkezköy", "Çorlu", "Hayrabolu", "Malkara", "Muratlı", "Saray", "Şarköy", "Marmaraereğlisi", "Ergene", "Süleymanpaşa"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 59,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Tokat
            ilceler = new List<string>(new string[]
                {
            "Almus", "Artova", "Erbaa", "Niksar", "Reşadiye", "Merkez", "Turhal", "Zile", "Pazar", "Yeşilyurt", "Başçiftlik", "Sulusaray"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 60,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Trabzon
            ilceler = new List<string>(new string[]
                {
            "Akçaabat", "Araklı", "Arsin", "Çaykara", "Maçka", "Of", "Sürmene", "Tonya", "Vakfıkebir", "Yomra", "Beşikdüzü", "Şalpazarı", "Çarşıbaşı", "Dernekpazarı", "Düzköy", "Hayrat", "Köprübaşı", "Ortahisar"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 61,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Tunceli
            ilceler = new List<string>(new string[]
                {
            "Çemişgezek", "Hozat", "Malazgirt", "Nazımiye", "Ovacık", "Pertek", "Pülümür", "Merkez"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 62,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Urfa
            ilceler = new List<string>(new string[]
                {
            "Akçakale", "Birecik", "Bozova", "Ceylanpınar", "Halfeti", "Hilvan", "Siverek", "Suruç", "Viranşehir", "Harran", "Eyyübiye", "Haliliye", "Karaköprü"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 63,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Uşak
            ilceler = new List<string>(new string[]
                {
            "Banaz", "Eşme", "Karahallı", "Sivaslı", "Ulubey", "Merkez"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 64,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Van
            ilceler = new List<string>(new string[]
                {
            "Başkale", "Çatak", "Erciş", "Gevaş", "Gürpınar", "Muradiye", "Özalp", "Bahçesaray", "Çaldıran", "Edremit", "Saray", "İpekyolu", "Tuşba"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 65,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Yozgat
            ilceler = new List<string>(new string[]
                {
            "Akdağmadeni", "Boğazlıyan", "Çayıralan", "Çekerek", "Sarıkaya", "Sorgun", "Şefaatli", "Yerköy", "Merkez", "Aydıncık", "Çandır", "Kadışehri", "Saraykent", "Yenifakılı"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 66,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Zonguldak
            ilceler = new List<string>(new string[]
                {
            "Çaycuma", "Devrek", "Ereğli", "Merkez", "Alaplı", "Gökçebey"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 67,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Bayburt
            ilceler = new List<string>(new string[]
                {
            "Merkez", "Aydıntepe", "Demirözü"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 69,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Karaman
            ilceler = new List<string>(new string[]
                {
            "Ermenek", "Merkez", "Ayrancı", "Kazımkarabekir", "Başyayla", "Sarıveliler"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 70,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Kırıkkale
            ilceler = new List<string>(new string[]
                {
            "Delice", "Keskin", "Merkez", "Sulakyurt", "Bahşili", "Balışeyh", "Çelebi", "Karakeçili", "Yahşihan"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 71,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Batman
            ilceler = new List<string>(new string[]
                {
            "Merkez", "Beşiri", "Gercüş", "Kozluk", "Sason", "Hasankeyf"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 72,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Şırnak
            ilceler = new List<string>(new string[]
                {
            "Beytüşşebap", "Cizre", "İdil", "Silopi", "Merkez", "Uludere", "Güçlükonak"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 73,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Bartın
            ilceler = new List<string>(new string[]
                {
            "Merkez", "Kurucaşile", "Ulus", "Amasra"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 74,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Ardahan
            ilceler = new List<string>(new string[]
                {
            "Merkez", "Çıldır", "Göle", "Hanak", "Posof", "Damal"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 75,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Iğdır
            ilceler = new List<string>(new string[]
                {
            "Aralık", "Merkez", "Tuzluca", "Karakoyunlu"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 76,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Yalova
            ilceler = new List<string>(new string[]
                {
            "Merkez", "Altınova", "Armutlu", "Çınarcık", "Çiftlikköy", "Termal"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 77,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Karabük
            ilceler = new List<string>(new string[]
                {
            "Eflani", "Eskipazar", "Merkez", "Ovacık", "Safranbolu", "Yenice"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 78,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Kilis
            ilceler = new List<string>(new string[]
                {
            "Merkez", "Elbeyli", "Musabeyli", "Polateli"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 79,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Osmaniye
            ilceler = new List<string>(new string[]
                {
            "Bahçe", "Kadirli", "Merkez", "Düziçi", "Hasanbeyli", "Sumbas", "Toprakkale"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
                    Adi = ilceler[i],
                    CityId = 80,
                };

                counties.Add(county);
            }

            modelBuilder.Entity<County>().HasData(counties); index += ilceler.Count;

            // Düzce
            ilceler = new List<string>(new string[]
                {
            "Akçakoca", "Merkez", "Yığılca", "Cumayeri", "Gölyaka", "Çilimli", "Gümüşova", "Kaynaşlı"
                });

            counties = new List<County>();

            for (int i = 0; i < ilceler.Count; i++)
            {
                County county = new County
                {
                    Id = i + 1 + index,
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
