using Application.Features.Commands.AppUser.CreateUser;
using ETicaretAPI.Application.Abstractions.Services;
using ETicaretAPI.Application.DTOs.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Commands.AppUser.CreateCustomer
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommandRequest, CreateCustomerCommandResponse>
    {
        readonly IUserService _userService;
        public CreateCustomerCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<CreateCustomerCommandResponse> Handle(CreateCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            CreateUserResponse response = await _userService.CreateCustomerAsync(new()
            {
                Email = request.Email,
                NameSurname = request.NameSurname,
                Password = request.Password,
                PasswordConfirm = request.PasswordConfirm,
                Username = request.Username,
            });

            return new()
            {
                Message = response.Message,
                Succeeded = response.Succeeded,
            };

            //throw new UserCreateFailedException();
        }
    }
}
