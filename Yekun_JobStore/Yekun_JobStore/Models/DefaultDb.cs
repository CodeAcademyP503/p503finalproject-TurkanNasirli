using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yekun_JobStore.Models.ViewModels;

namespace Yekun_JobStore.Models
{
    public class DefaultDb
    {

        public static void Seed(JobstoreDbContext jobstoreDbContext, RoleManager<IdentityRole> roleManager)
        {

            if (!jobstoreDbContext.Roles.Any())
            {
                string[] roleNames = Enum.GetNames(typeof(RoleType));
                foreach (string role in roleNames)
                {
                    IdentityRole identityRole = new IdentityRole(role);
                    roleManager.CreateAsync(identityRole).GetAwaiter().GetResult();

                }

            }

            if (!jobstoreDbContext.Cities.Any())
            {
                #region Cities
                City City1 = new City
                {
                    Name = "Ağcabədi"
                };
                City City2 = new City
                {
                    Name = "Ağdam"
                };
                City City3 = new City
                {
                    Name = "Ağstafa‎"
                };
                City City4 = new City
                {
                    Name = "Ağdaş‎"
                };
                City City5 = new City
                {
                    Name = "Ağsu‎"
                };
                City City6 = new City
                {
                    Name = "Bakı‎"
                };
                City City7 = new City
                {
                    Name = "Balakən"
                };
                City City8 = new City
                {
                    Name = "Beyləqan"
                };
                City City9 = new City
                {
                    Name = "Bərdə"
                };
                City City10 = new City
                {
                    Name = "Biləsuvar"
                };
                City City11 = new City
                {
                    Name = "Cəbrayıl‎"
                };
                City City12 = new City
                {
                    Name = "Cəlilabad"
                };
                City City13 = new City
                {
                    Name = "Daşkəsən‎"
                };
                City City14 = new City
                {
                    Name = "Füzuli"
                };
                City City15 = new City
                {
                    Name = "Gədəbəy"
                };
                City City16 = new City
                {
                    Name = "Gəncə"
                };
                City City17 = new City
                {
                    Name = "Goranboy"
                };
                City City18 = new City
                {
                    Name = "Göyçay‎"
                };
                City City19 = new City
                {
                    Name = "Göygöl"
                };
                City City20 = new City
                {
                    Name = "Hacıqabul‎"
                };
                City City21 = new City
                {
                    Name = "Xaçmaz"
                };
                City City22 = new City
                {
                    Name = "Xankəndi"
                };
                City City23 = new City
                {
                    Name = "Culfa"
                };
                City City24 = new City
                {
                    Name = "Xocavənd"
                };
                City City25 = new City
                {
                    Name = "Xırdalan"
                };
                City City26 = new City
                {
                    Name = "Xızı"
                };
                City City27 = new City
                {
                    Name = "Xocalı"
                };
                City City28 = new City
                {
                    Name = "Xocavənd"
                };
                City City29 = new City
                {
                    Name = "İmişli"
                };
                City City30 = new City
                {
                    Name = "İsmayıllı"
                };
                City City31 = new City
                {
                    Name = "Kəlbəcər"
                };
                City City32 = new City
                {
                    Name = "Kəngərli"
                };
                City City33 = new City
                {
                    Name = "Kürdəmir"
                };
                City City34 = new City
                {
                    Name = "Qax"
                };
                City City35 = new City
                {
                    Name = "Qazax"
                };
                City City36 = new City
                {
                    Name = "Qəbələ"
                };
                City City37 = new City
                {
                    Name = "Qobustan"
                };
                City City38 = new City
                {
                    Name = "Quba"
                };
                City City39 = new City
                {
                    Name = "Qubadlı"
                };
                City City40 = new City
                {
                    Name = "Qusar"
                };
                City City41 = new City
                {
                    Name = "Laçın"
                };
                City City42 = new City
                {
                    Name = "Lerik"
                };
                City City43 = new City
                {
                    Name = "Lənkəran"
                };
                City City44 = new City
                {
                    Name = "Masallı"
                };
                City City70 = new City
                {
                    Name = "Mingəçevir"
                };
                City City45 = new City
                {
                    Name = "Neftçala"
                };
                City City71 = new City
                {
                    Name = "Naftalan"
                };
                City City46 = new City
                {
                    Name = "Oğuz"
                };
                City City47 = new City
                {
                    Name = "Ordubad"
                };
                City City48 = new City
                {
                    Name = "Saatlı"
                };
                City City49 = new City
                {
                    Name = "Sabirabad"
                };
                City City50 = new City
                {
                    Name = "Salyan"
                };
                City City51 = new City
                {
                    Name = "Samux"
                };
                City City52 = new City
                {
                    Name = "Sədərək"
                };
                City City53 = new City
                {
                    Name = "Siyəzən"
                };
                City City54 = new City
                {
                    Name = "Şabran"
                };
                City City55 = new City
                {
                    Name = "Şahbuz"
                };
                City City56 = new City
                {
                    Name = "Şamaxı"
                };
                City City57 = new City
                {
                    Name = "Şəki"
                };
                City City58 = new City
                {
                    Name = "Şəmkir"
                };
                City City59 = new City
                {
                    Name = "Şərur"
                };
                City City69 = new City
                {
                    Name = "Sumqayıt"
                };
                City City60 = new City
                {
                    Name = "Şuşa"
                };
                City City61 = new City
                {
                    Name = "Tərtər"
                };
                City City62 = new City
                {
                    Name = "Tovuz"
                };
                City City63 = new City
                {
                    Name = "Ucar"
                };
                City City64 = new City
                {
                    Name = "Yardımlı"
                };
                City City65 = new City
                {
                    Name = "Yevlax"
                };
                City City66 = new City
                {
                    Name = "Zaqatala"
                };
                City City67 = new City
                {
                    Name = "Zəngilan"
                };
                City City68 = new City
                {
                    Name = "Zərdab"
                };
                jobstoreDbContext.Cities.AddRange(City1, City2, City3, City4, City5,
                                        City6, City7, City8, City9, City10, City11, City11,
                                        City12, City13, City14, City15, City16, City17, City18, City19,
                                        City20, City21, City22, City23, City24, City25, City26, City27, City28,
                                        City29, City30, City31, City31, City32, City33, City34, City35, City36, City37,
                                        City38, City39, City40, City41, City42, City43, City44, City45, City46, City47, City48, City49,
                                        City50, City51, City52, City53, City54, City55, City56, City57, City58, City59, City60, City61, City62,
                                        City63, City64, City65, City66, City67, City68, City69, City70, City71);
                jobstoreDbContext.SaveChanges();
            }
            #endregion


            if (!jobstoreDbContext.Experiences.Any())
            {
                #region Experiences
                Experience experience = new Experience
                {
                    Name = "-"
                };
                Experience experience1 = new Experience
                {
                    Name = "1 ildən aşağı"
                };
                Experience experience2 = new Experience
                {
                    Name = "1 ildən 3 ilə qədər"
                };
                Experience experience3 = new Experience
                {
                    Name = "2 ildən artıq"
                };
                Experience experience4 = new Experience
                {
                    Name = "3 ildən 5 ilə qədər"
                };
                Experience experience5 = new Experience
                {
                    Name = "4 ildən artıq"
                };
                Experience experience6 = new Experience
                {
                    Name = "5 ildən artıq"
                };
                jobstoreDbContext.Experiences.AddRange(experience, experience1, experience2, experience3, experience4,
                                                       experience5, experience6);
                jobstoreDbContext.SaveChanges();
            }
            #endregion

            if (!jobstoreDbContext.Educations.Any())
            {
                #region Educations
                Education education = new Education()
                {
                    Name = "-"
                };
                Education education1 = new Education()
                {
                    Name = "Ali"
                };
                Education education2 = new Education()
                {
                    Name = "Elmi dərəcə"
                };
                Education education3 = new Education()
                {
                    Name = "Natamam ali"
                };
                Education education4 = new Education()
                {
                    Name = "Orta"
                };
                Education education5 = new Education()
                {
                    Name = "Orta texniki"
                };
                Education education6 = new Education()
                {
                    Name = "Orta xüsusi"
                };
                jobstoreDbContext.Educations.AddRange(education, education1, education2, education3,
                                                    education4, education5, education6);
                jobstoreDbContext.SaveChanges();
            }
            #endregion

        }
    }
}
