﻿Module Module_global
    ' global variables to encourage information flow between different forms
    Public User_ID As Integer = 2
    Public Provider_ID As Integer = 3
    Public Email As String = ""
    Public user_appo_det_dealID_upcoming As Integer = 1
    Public user_appo_det_dealID_completed As Integer = 1
    Public DealID_Reschedule = 2
    Public Appointment_Det_DealId As Integer = 1
    Public slot_back_choice As Integer = 1
    Public cost_of_booking As Integer
    Public payment_successful As Integer = 0
    Public serviceType As String = ""
    Public service_types As List(Of String) = New List(Of String) From {"Cleaning", "Plumbing", "Electrical", "Painting", "Decorating", "Catering", "Photography", "Others"}
    Public provider_locations As List(Of String) = New List(Of String) From {"Panbazar", "Dispur", "Chandmari", "Zoo Road", "Beltola", "Khanapara", "Hatigaon", "Jalukbari", "Maligaon", "Garchuk"}
End Module

