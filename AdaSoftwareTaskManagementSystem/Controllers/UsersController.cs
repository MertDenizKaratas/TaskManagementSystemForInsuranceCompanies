using Application.Features.Commands.AppUser.CreateCustomer;
using Application.Features.Commands.AppUser.CreateEmployee;
using Application.Features.Commands.AppUser.CreateUser;
using ETicaretAPI.Application.Abstractions.Services;
using ETicaretAPI.Application.CustomAttributes;
using ETicaretAPI.Application.Enums;
using ETicaretAPI.Application.Features.Commands.AppUser.AssignRoleToUser;


using ETicaretAPI.Application.Features.Commands.AppUser.LoginUser;
using ETicaretAPI.Application.Features.Commands.AppUser.UpdatePassword;
using ETicaretAPI.Application.Features.Queries.AppUser.GetAllUsers;
using ETicaretAPI.Application.Features.Queries.AppUser.GetRolesToUser;
using ETicaretAPI.Application.Features.Queries.AppUser.GetUserById;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        readonly IMediator _mediator;
        public UsersController(IMediator mediator)
        {
            _mediator = mediator;

        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommandRequest createUserCommandRequest)
        {
            CreateUserCommandResponse response = await _mediator.Send(createUserCommandRequest);
            return Ok(response);
        }
        [HttpPost("create-customer")]
        public async Task<IActionResult> CreateCustomer(CreateCustomerCommandRequest CreateCustomerCommandRequest)
        {
            CreateCustomerCommandResponse response = await _mediator.Send(CreateCustomerCommandRequest);
            return Ok(response);
        }
        [HttpPost("create-employee")]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeCommandRequest CreateEmployeeCommandRequest)
        {
            CreateEmployeeCommandResponse response = await _mediator.Send(CreateEmployeeCommandRequest);
            return Ok(response);
        }
        [HttpPost("update-password")]
        public async Task<IActionResult> UpdatePassword([FromBody] UpdatePasswordCommandRequest updatePasswordCommandRequest)
        {
            UpdatePasswordCommandResponse response = await _mediator.Send(updatePasswordCommandRequest);
            return Ok(response);
        }

        [HttpGet]
        [AuthorizeDefinition(ActionType = ActionType.Reading, Definition = "Get All Users", Menu = "Users")]
        public async Task<IActionResult> GetAllUsers([FromQuery] GetAllUsersQueryRequest getAllUsersQueryRequest)
        {
            GetAllUsersQueryResponse response = await _mediator.Send(getAllUsersQueryRequest);
            return Ok(response);
        }

        [HttpGet("get-roles-to-user/{UserId}")]
        public async Task<IActionResult> GetRolesToUser([FromRoute]GetRolesToUserQueryRequest getRolesToUserQueryRequest)
        {
            GetRolesToUserQueryResponse response = await _mediator.Send(getRolesToUserQueryRequest);
            return Ok(response);
        }

        [HttpPost("assign-role-to-user")]
        public async Task<IActionResult> AssignRoleToUser(AssignRoleToUserCommandRequest assignRoleToUserCommandRequest)
        {
            AssignRoleToUserCommandResponse response = await _mediator.Send(assignRoleToUserCommandRequest);
            return Ok(response);
        }
        [HttpGet("{refreshToken}")]
        [AuthorizeDefinition(ActionType = ActionType.Reading, Definition = "Get User By Id", Menu = "Users")]
        public async Task<IActionResult> GetUserByRefresh([FromRoute] GetUserByIdQueryRequest getUserByIdQueryRequest)
        {
            GetUserByIdQueryResponse response = await _mediator.Send(getUserByIdQueryRequest);
            return Ok(response);
        }

    }
}
