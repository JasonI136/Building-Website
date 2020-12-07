using Palisade.Domain.Entity;
using Palisade.Domain.Repository;
using Palisade.Interface.Domain;
using Palisade.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Palisade.Service
{
    public class UserService : IUserService
    {
        IRepository _repository;
        public UserService(IRepository repository)
        {
            _repository = repository;
        }

        public UserDTO Login(UserDTO userDto)
        {
            var user = _repository.GetUser().WithEmail(userDto.Email);

            if (user == null)
            {
                userDto.Password = string.Empty;
                userDto.isSuccess = false;
                return userDto;
            }

            if (user.Password != userDto.Password)
            {
                userDto.Password = string.Empty;
                userDto.isSuccess = false;
                return userDto;
            }

            userDto.FirstName = user.FirstName;
            userDto.LastName = user.LastName;
            userDto.Password = user.Password;
            userDto.Email = user.Email;
            userDto.Id = user.Id;
            userDto.PhoneNumber = user.PhoneNumber;
            userDto.Dob = user.Dob;
            userDto.isSuccess = true;
            return userDto;
        }

        public UserDTO Register(UserDTO userDto)
        {
            // make new bool to check if the data is complete
            bool dataComplete = true;

            // make sure all the input exists or is valid
            if (string.IsNullOrWhiteSpace(userDto.FirstName))
            {
                userDto.Password = string.Empty;
                userDto.Messages.Add("First Name shouldnt be empty");
                dataComplete = false;
            }

            if (string.IsNullOrWhiteSpace(userDto.LastName))
            {
                userDto.Password = string.Empty;
                userDto.Messages.Add("Last Name shouldnt be empty");
                dataComplete = false;
            }

            if (string.IsNullOrWhiteSpace(userDto.Email))
            {
                userDto.Password = string.Empty;
                userDto.Messages.Add("Email shouldnt be empty");
                dataComplete = false;
            }

            if (string.IsNullOrWhiteSpace(userDto.Password))
            {
                userDto.Password = string.Empty;
                userDto.Messages.Add("Password shouldnt be empty");
                dataComplete = false;
            }

            if (userDto.Dob == null)
            {
                userDto.Password = string.Empty;
                userDto.Messages.Add("Date of Birth shouldnt be empty");
                dataComplete = false;
            }

            if (string.IsNullOrWhiteSpace(userDto.PhoneNumber))
            {
                userDto.Password = string.Empty;
                userDto.Messages.Add("Phone Number shouldnt be empty");
                dataComplete = false;
            }


            // Makes sure that all if cases pass
            if (!dataComplete)
            {
                userDto.isSuccess = false;
                return userDto;
            }

            var userEmail = _repository.GetUser().WithEmail(userDto.Email);
            if (userEmail != null)
            {
                userDto.isSuccess = false;
                userDto.Messages.Add("You already have this email signed up");
                return userDto;
            }

            // Convert DTO to entity, call save user from the repository (save the data Check previous work)
            // if correct, save the user details
            var user = new User()
            {
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Email = userDto.Email,
                Password = userDto.Password,
                Dob = userDto.Dob,
                PhoneNumber = userDto.PhoneNumber,
            };

            _repository.PostUser(user);
            userDto.Id = user.Id;
            userDto.isSuccess = true;
            userDto.Messages.Add("User has registered successfully");
            return userDto;
        }
    }
}
