using System;
using System.Threading.Tasks;
using AutoMapper;
using Manager.API.ViewModels;
using Manager.Core.Exceptions;
using Manager.Services.DTO;
using Manager.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Manager.API.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("/api/v1/create")] 
        public  async Task<IActionResult> Create([FromBody]CreateUserViewModel userViewModel){
           try{ 
               var userDTO = _mapper.Map<UserDTO>(userViewModel);
               var userCreated = await _userService.Create(userDTO);
          
            return Ok(new ResultViewModel{
                Message = "Usuário criado com sucesso!",
                Success = true,
                Data = userCreated
            });
 
 
            }
            catch(DomainException ex ){
              return BadRequest();
            }
            catch(Exception){
            return StatusCode(500, "erro");
            }

        }
            
    }
}