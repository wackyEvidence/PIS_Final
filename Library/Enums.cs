namespace Library
{
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
        ExecutiveBranchOfStatePower, // исполнительный орган государственной власти 
        Council, // орган местного самоуправления 
        AnimalShelter, // приют
        AnimalTrappingOrganization, // организация по отлову 
        AnimalTrappingAndShelteringOrganization, // организация по отлову и приют 
        AnimalTransportationOrganization, // организация по транспортировке
        StateVetClinic, // государственная ветеринарная клиника 
        MunicipalVetClinic, // муниципальная ветеринарная клиника
        PrivateVetClinic, // частная ветеринарная клиника 
        CharitableFoundation, // благотворительный фонд
        OrganizationsForSalingGoodsAndServicesForAnimals, // организации по продаже товаров и предоставлению услуг для животных
        Applicant // заявитель (для регистрации представителя юридического лица, подающего заявку на отлов) 
    }
}
