# GroupAPIBlueBadge

## Overview
Our project is the Pet Service Pro – an all-inclusive tool to assist pet owners to find healthy walking and/or minding services to help pets stay active, and to give their families peace of mind.
We recognize that during the Covid19 pandemic many persons adopted a pet to help manage the stress of lockdown and isolation.  We felt that as the pandemic winds down, and as new pet owners are faced with the reality of returning to a ‘normal’ work environment, additional stress and concern may arise as newly adopted pets are left at home.  Our project is meant to help find solutions to the growing need to find ways to assure pets adjust or pet owners to have new options in keeping their pets healthy and happy.
Our API contains information and programming designed to present the user selection criteria based on Location and the Individual ‘Walker’ who will provide the service.   The user first enters information about the Pet.  Once completed the user uses selection criteria (Location and/ Walker) to find a service appropriate for his/her needs.  A list of ‘Walk Services’ is then presented based on the selection criteria.  Additionally, a list of all available services can be presented.
A list of Scheduled Walks can also be presented to verify a selected service has successfully been scheduled for the pet.

## API Request

**Pet**
```POST api/Pet``` To create an instance of your pet you need to first:
1. PetType - Enter in the type of pet you have.
2. PetName - Enter the Name of your pet.

```GET api/Pet``` A GET request will return all of the pets posted by the user.

```GET api/Pet{id}``` A GET request with an id will search for the pet posted by the user with that id. If none exist it will return a 404

```PUT api/pet``` A PUT request is used to update the pet information.

```DELETE api/pet/{id}``` This deletes the pet from the database

###### Stretch Goals
Areas open to further development include at the very least adding additional objects pertinent to Pets, Pet Owners, and Walkers.  For example information about the location and preferences of the Walkers may additionally improve the helpfulness and accuracy of the project.
Integration with Google Maps would most certainly enhance information about the Walk Events.

 
