using System.ComponentModel.DataAnnotations;
using DesignPattern.Enum;

namespace DesignPattern.DTO.Request;

public class Notification
{
    [Required]
    public NotificationMediumEnum NotificationMedium  { get; set; }
    
    [Required]
    public NotificationEnum NotificationProvider { get; set; }
};