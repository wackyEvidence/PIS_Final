namespace Library
{
    public enum SortOrder
    {
        Ascending, 
        Descending, 
        None
    }
    public enum AnimalCategory
    {
        Dog, 
        Cat
    }
    
    public enum UserRole
    {
        VetServiceCurator, // куратор вет. службы 
        TrappingCurator, // куратор по отлову
        AnimalShelterCurator, // куратор приюта 
        VetServiceOperator, // оператор вет службы
        TrappingOperator, // оператор по отлову 
        VetServiceSignatory, // подписант вет. службы 
        TrappingSignatory, // подписант по отлову
        AnimalShelterSignatory, // подписант приюта 
        OMSU_Curator, // куратор ОМСУ, 
        OMSU_Signatory, // подписант ОМСУ
        OMSU_Operator, // оператор ОМСУ
        AnimalShelterOperator, // оператор приюта 
        Veterinarian, // ветврач
        AnimalShelterVeterinarian // ветврач приюта
    }

    public enum OrganizationalAttribute
    { 
        IndividualEntrepreneur, // ИП
        LegalEntity // Юр. лицо 
    }


    public enum OrganizationType
    {
        ExecutiveBranchOfStatePower = 0, // исполнительный орган государственной власти 
        Council = 1, // орган местного самоуправления 
        AnimalShelter = 2, // приют
        AnimalTrappingOrganization = 3, // организация по отлову 
        AnimalTrappingAndShelteringOrganization = 4, // организация по отлову и приют 
        AnimalTransportationOrganization = 5, // организация по транспортировке
        StateVetClinic = 6, // государственная ветеринарная клиника 
        MunicipalVetClinic = 7, // муниципальная ветеринарная клиника
        PrivateVetClinic = 8, // частная ветеринарная клиника 
        CharitableFoundation = 9, // благотворительный фонд
        OrganizationsForSalingGoodsAndServicesForAnimals = 10, // организации по продаже товаров и предоставлению услуг для животных
        Applicant = 11 // заявитель (для регистрации представителя юридического лица, подающего заявку на отлов) 
    }
}
