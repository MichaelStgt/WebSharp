/* Copyright (c) 2016 Xamarin. */

/* NOTE: this is auto-generated from IDL */
/* From ppp_input_event.idl modified Thu May 12 07:00:00 2016. */

using System;
using System.Runtime.InteropServices;

namespace PepperSharp {


/**
 * @file
 * This file defines the API for receiving input events from the browser.
 */


/**
 * @addtogroup Interfaces
 * @{
 */
internal static partial class PPPInputEvent {
  [DllImport("PepperPlugin", EntryPoint = "PPP_InputEvent_HandleInputEvent")]
  extern static PPBool _HandleInputEvent ( PPInstance instance,
                                           PPResource input_event);

  /**
   * Function for receiving input events from the browser.
   *
   * In order to receive input events, you must register for them by calling
   * PPB_InputEvent.RequestInputEvents() or RequestFilteringInputEvents(). By
   * default, no events are delivered.
   *
   * If the event was handled, it will not be forwarded to the default handlers
   * in the web page.  If it was not handled, it may be dispatched to a default
   * handler. So it is important that an instance respond accurately with
   * whether event propagation should continue.
   *
   * Event propagation also controls focus. If you handle an event like a mouse
   * event, typically the instance will be given focus. Returning false from
   * a filtered event handler or not registering for an event type means that
   * the click will be given to a lower part of the page and your instance will
   * not receive focus. This allows an instance to be partially transparent,
   * where clicks on the transparent areas will behave like clicks to the
   * underlying page.
   *
   * In general, you should try to keep input event handling short. Especially
   * for filtered input events, the browser or page may be blocked waiting for
   * you to respond.
   *
   * The caller of this function will maintain a reference to the input event
   * resource during this call. Unless you take a reference to the resource
   * to hold it for later, you don't need to release it.
   *
   * <strong>Note:</strong> If you're not receiving input events, make sure you
   * register for the event classes you want by calling RequestInputEvents or
   * RequestFilteringInputEvents. If you're still not receiving keyboard input
   * events, make sure you're returning true (or using a non-filtered event
   * handler) for mouse events. Otherwise, the instance will not receive focus
   * and keyboard events will not be sent.
   *
   * \see PPB_InputEvent.RequestInputEvents and
   * PPB_InputEvent.RequestFilteringInputEvents
   *
   * @return PP_TRUE if the event was handled, PP_FALSE if not. If you have
   * registered to filter this class of events by calling
   * RequestFilteringInputEvents, and you return PP_FALSE, the event will
   * be forwarded to the page (and eventually the browser) for the default
   * handling. For non-filtered events, the return value will be ignored.
   */
  public static PPBool HandleInputEvent ( PPInstance instance,
                                          PPResource input_event)
  {
  	return _HandleInputEvent (instance, input_event);
  }


}
/**
 * @}
 */


}
