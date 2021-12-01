using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Extensions;
using API.Helpers;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
[Authorize]    
        public class MessagesController : BaseApiController
    {
        public IUserRepository _userRepository { get; }
        public IMessageRepository _messageRepository { get; }
        public IMapper _mapper{get;}
       
       
       
        public MessagesController(IUserRepository userRepository, 
                                            IMessageRepository messageRepository,
                                            IMapper  mapper)
            {
            _mapper = mapper;
            _messageRepository = messageRepository;
           _userRepository = userRepository;
           }



  [HttpPost] 
  public async Task<ActionResult<MessageDto>> CreateMessage(CreateMessageDto createMessageDto)
   {
    var username=User.GetUsername();

         if(username==createMessageDto.RecipientUsername.ToLower())
         return BadRequest("It's not possible to message yourself");

            var sender = await _userRepository.GetUserByUsernameAsync(username);  //184@3m
            var recepient = await _userRepository.GetUserByUsernameAsync(createMessageDto.RecipientUsername);
                if(recepient==null) return NotFound(); //getting this far means you are ready to create a new message

        var message= new Message
        {
            Sender = sender,
            Recipient= recepient,
            SenderUsername=sender.UserName,
            RecipientUsername=recepient.UserName,
            Content=createMessageDto.Content

        };
    
            _messageRepository.AddMessage(message);

            if(await _messageRepository.SaveAllAsync()) 

            return Ok(_mapper.Map<MessageDto>(message));


            return BadRequest("Message not sent, something failed!");
            

    }


[HttpGet]  
public async Task<ActionResult<IEnumerable<MessageDto>>> GetMessagesForUser( [FromQuery] MessageParams messageParams)
               {
                        messageParams.Username=User.GetUsername();
                        var messages= await _messageRepository.GetMessagesForUser(messageParams);

                        Response.AddPaginationHeader(
                            messages.CurrentPage, 
                            messages.PageSize, 
                            messages.TotalCount,
                            messages.TotalPages);

                            return messages;
                }



[HttpGet("thread/{username}")]
        public async Task<ActionResult<IEnumerable<MessageDto>>> GetMessageThread(string username)
        {
            var currentUsername = User.GetUsername();

            return Ok(await _messageRepository.GetMessageThread(currentUsername, username));
        }








    }


}