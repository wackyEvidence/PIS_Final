namespace Library
{
    public enum AnimalCategory
    {
        Dog, 
        Cat
    }

    public enum UserRole
    {

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
