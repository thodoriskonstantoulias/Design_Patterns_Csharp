using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace State_Design_Pattern.Logic
{
    class PendingState : BookingState
    {
        CancellationTokenSource token;
        public override void Cancel(BookingContext booking)
        {
            token.Cancel();
        }

        public override void DatePassed(BookingContext booking)
        {

        }

        public override void EnterDetails(BookingContext booking, string attendee, int ticketCount)
        {

        }

        public override void EnterState(BookingContext booking)
        {
            token = new CancellationTokenSource();
            booking.ShowState("Pending");
            booking.View.ShowStatusPage("Processing booking");

            StaticFunctions.ProcessBooking(booking, ProcessingComplete, token);
        }

        public void ProcessingComplete(BookingContext booking, ProcessingResult result)
        {
            switch (result)
            {
                case ProcessingResult.Sucess:
                    booking.TransitionToState(new BookedState());
                    break;
                case ProcessingResult.Fail:
                    booking.View.ShowProcessingError();
                    booking.TransitionToState(new NewState());
                    break;
                case ProcessingResult.Cancel:
                    booking.TransitionToState(new ClosedState("Processing canceled"));
                    break;
            }
        }
    }
}
