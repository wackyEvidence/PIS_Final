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
        VetServiceCurator = 0, // куратор вет. службы     // ДОБАВЛЕНО 
        TrappingCurator = 1, // куратор по отлову
        AnimalShelterCurator = 2, // куратор приюта       // ДОБАВЛЕНО 
        VetServiceOperator = 3, // оператор вет службы    // ДОБАВЛЕНО
        TrappingOperator = 4, // оператор по отлову       // ДОБАВЛЕНО
        VetServiceSignatory = 5, // подписант вет. службы // ДОБАВЛЕНО
        TrappingSignatory = 6, // подписант по отлову     // ДОБАВЛЕНО
        AnimalShelterSignatory = 7, // подписант приюта 
        OMSU_Curator = 8, // куратор ОМСУ,                // ДОБАВЛЕНО
        OMSU_Signatory = 9, // подписант ОМСУ
        OMSU_Operator = 10, // оператор ОМСУ              // ДОБАВЛЕНО
        AnimalShelterOperator = 11, // оператор приюта    // ДОБАВЛЕНО 
        Veterinarian = 12, // ветврач                     // ДОБАВЛЕНО 
        AnimalShelterVeterinarian = 13 // ветврач приюта
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
